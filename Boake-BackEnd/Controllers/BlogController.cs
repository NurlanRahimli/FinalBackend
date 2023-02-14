using Boake_BackEnd.DAL;
using Boake_BackEnd.Models;
using Boake_BackEnd.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Boake_BackEnd.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private UserManager<AppUser> _userManager;
        public BlogController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Tags = _context.Tags.Where(b => !b.IsDeleted).ToList();

            List<Blog> blogs = await _context.Blog.Include(b => b.Comments).Where(b => !b.IsDeleted).ToListAsync();
            return View(blogs);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Comments = _context.Comments.Include(c => c.Blog).Include(c => c.AppUser).Where(c => c.BlogId == id).ToList();
            ViewBag.Count = _context.Comments.Include(c => c.Blog).Include(c => c.AppUser).Where(c => c.BlogId == id).ToList().Count();
            ViewBag.Bio = _context.Bio.FirstOrDefault();
            ViewBag.Tags = _context.Tags.Where(b => !b.IsDeleted).ToList();

            List<Blog> blogs = _context.Blog.Where(b => !b.IsDeleted).ToList();
            Blog blog = await _context.Blog.Include(b => b.BlogTags).ThenInclude(b => b.Tag).FirstOrDefaultAsync(b => !b.IsDeleted && b.Id == id);

            if (blog == null)
            {
                return RedirectToAction("index", "error");
            }

            BlogVM blogVM = new BlogVM()
            {
                Blog = blog,
                Blogs = blogs
            };
            return View(blogVM);
        }
        public IActionResult Blogtag(int id)
        {
            List<Blog> blogs = _context.Blog.Include(b => b.Comments).Where(c => !c.IsDeleted && c.BlogTags.Any(bt => bt.TagId == id)).ToList();
            ViewBag.Tags = _context.Tags.Where(b => !b.IsDeleted).ToList();
            List<Blog> blogsfortag = _context.Blog.Where(b => !b.IsDeleted).ToList();

            BlogVM blogVM = new BlogVM()
            {
                Blogs = blogs,
                BlogsForTag = blogsfortag
            };
            return View(blogVM);
        }
        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public async Task<IActionResult> AddComment(Comment comment)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("login", "account");
            }
            else
            {

                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user == null) { return RedirectToAction("login", "account"); }
                if (!ModelState.IsValid) return RedirectToAction("Detail", "Blog", new { id = comment.BlogId });
                if (!_context.Blog.Any(f => f.Id == comment.BlogId)) return NotFound();
                Comment newComment = new Comment
                {
                    Message = comment.Message,
                    BlogId = comment.BlogId,
                    CreatedTime = DateTime.Now,
                    AppUserId = user.Id,
                    IsAccess = true,
                };
                _context.Comments.Add(newComment);
                _context.SaveChanges();
                return RedirectToAction("Detail", "Blog", new { id = comment.BlogId });
            }
        }
        public async Task<IActionResult> DeleteComment(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("login", "account");
            }
            else
            {

                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user == null) { return RedirectToAction("login", "account"); }

                if (!ModelState.IsValid) return RedirectToAction("Index", "Blog");
                if (!_context.Comments.Any(c => c.Id == id && c.IsAccess == true && c.AppUserId == user.Id)) return NotFound();
                Comment comment = _context.Comments.FirstOrDefault(c => c.Id == id && c.AppUserId == user.Id);
                _context.Comments.Remove(comment);
                _context.SaveChanges();
                return RedirectToAction("Detail", "Blog", new { id = comment.BlogId });
            }
        }
        public IActionResult DeleteCommentAdmin(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("login", "account");
            }
            else
            {

                if (!ModelState.IsValid) return RedirectToAction("Index", "Blog");
                if (!_context.Comments.Any(c => c.Id == id && c.IsAccess == true)) return NotFound();
                Comment comment = _context.Comments.FirstOrDefault(c => c.Id == id);
                _context.Comments.Remove(comment);
                _context.SaveChanges();
                return RedirectToAction("Detail", "Blog", new { id = comment.BlogId });
            }
        }
    }
}
