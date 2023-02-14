using Boake_BackEnd.DAL;
using Boake_BackEnd.Helpers;
using Boake_BackEnd.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Boake_BackEnd.Extensions;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace Boake_BackEnd.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "SuperAdmin")]

    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BlogController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            ViewBag.Tags = _context.Tags.Where(t => !t.IsDeleted).ToList();
            List<Blog> blogs = _context.Blog.Include(b=>b.BlogTags).ThenInclude(b=>b.Tag).Where(b=>!b.IsDeleted).ToList();
            return View(blogs);
        } 

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Blog db = _context.Blog.Find(id);
            if (db == null) return NotFound();
            db.IsDeleted= true;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            ViewBag.Tags = _context.Tags.Where(t=>!t.IsDeleted).ToList();

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog Blog)
        {
            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!Blog.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Sekil Formati secin");
            }

            if (Blog.Photo.CheckSize(20000))
            {
                ModelState.AddModelError("Photo", "Sekil 20 mb-dan boyuk ola bilmez");
            }
            ViewBag.Tags = _context.Tags.Where(t => !t.IsDeleted).ToList();


            string filename = await Blog.Photo.SaveFile(_env, "assets/img/blog");
            Blog.ImageUrl = filename; 
            Blog.CreatedTime = DateTime.Now;

            Blog.BlogTags = new List<BlogTag>();
            if (Blog.TagIds != null)
            {
                foreach (var tagId in Blog.TagIds)
                {
                    BlogTag pTag = new BlogTag
                    {
                        Blog = Blog,
                        TagId = tagId
                    };
                    _context.BlogTags.Add(pTag);
                }
            }
            _context.Blog.Add(Blog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Tags = _context.Tags.Include(b => b.BlogTags).ThenInclude(b => b.Tag).Where(t => !t.IsDeleted).ToList();

            Blog blog = _context.Blog.Include(b => b.BlogTags).ThenInclude(b => b.Tag).FirstOrDefault(b=>b.Id==id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int? id, Blog Blog)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Tags = _context.Tags.Include(b => b.BlogTags).ThenInclude(b => b.Tag).Where(t => !t.IsDeleted).ToList();

           
            Blog db = _context.Blog.Include(b => b.BlogTags).ThenInclude(b => b.Tag).FirstOrDefault(b=>b.Id==id);
            if (db == null)
            {
                return NotFound();
            }
            if (Blog.Photo != null)
            {

                if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    return View();
                }

                if (!Blog.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Sekil Formati secin");
                }

                if (Blog.Photo.CheckSize(20000))
                {
                    ModelState.AddModelError("Photo", "Sekil 20 mb-dan boyuk ola bilmez");
                }
                Helper.DeleteFile(_env, "assets/img/Blog", db.ImageUrl);
                string filename = await Blog.Photo.SaveFile(_env, "assets/img/Blog");
                db.ImageUrl = filename;
            }
            else
            {
                db.ImageUrl = db.ImageUrl;
            }
             
            Blog existName = _context.Blog.FirstOrDefault(x => x.Title.ToLower() == Blog.Title.ToLower());

            if (existName != null)
            {
                if (db != existName)
                {
                    ModelState.AddModelError("Title", "Name Already Exist");
                    return View();
                }
            }
             
            db.Title = Blog.Title;
            db.Description = Blog.Description;
            db.UpdatedTime = DateTime.Now;
            var existTags = _context.BlogTags.Where(x => x.BlogId == Blog.Id &&!x.IsDeleted).ToList();
            if (Blog.TagIds != null)
            {
                foreach (var tagId in Blog.TagIds)
                {
                    var existTag = existTags.FirstOrDefault(x => x.TagId == tagId);
                    if (existTag == null)
                    {
                        BlogTag blogTag = new BlogTag
                        {
                            BlogId = Blog.Id,
                            TagId = tagId,
                        };

                        _context.BlogTags.Add(blogTag);
                    }
                    else
                    {
                        existTags.Remove(existTag);
                    }
                }

            }
            _context.BlogTags.RemoveRange(existTags);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Blog blog = _context.Blog.Where(b=>!b.IsDeleted).FirstOrDefault(b=>b.Id==id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }
    }
}
