using Boake_BackEnd.DAL;
using Boake_BackEnd.Extensions;
using Boake_BackEnd.Helpers;
using Boake_BackEnd.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Boake_BackEnd.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    //[Authorize(Roles = "SuperAdmin")]

    public class BookController : Controller
    {
        private readonly AppDbContext _context;

        private readonly IWebHostEnvironment _env;
        public BookController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Book> books = _context.Books.Where(b => !b.IsDeleted).ToList();
            return View(books);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book db = _context.Books.Find(id);
            if (db == null) return NotFound();
            db.IsDeleted = true;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            ViewBag.Campaigns = _context.Campaigns.ToList();
            ViewBag.Tags = _context.Tags.Where(t => !t.IsDeleted).ToList();
            ViewBag.Categories = _context.Categories.Where(t => !t.IsDeleted).ToList();
            ViewBag.Authors = _context.Authors.Where(t => !t.IsDeleted).ToList();
            ViewBag.ProductTypes = _context.ProductTypes.Where(t => !t.IsDeleted).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Book book)
        {
            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!book.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Sekil Formati secin");
            }

            if (book.Photo.CheckSize(20000))
            {
                ModelState.AddModelError("Photo", "Sekil 20 mb-dan boyuk ola bilmez");
            }
            ViewBag.Tags = _context.Tags.Where(t => !t.IsDeleted).ToList();
            ViewBag.Categories = _context.Categories.Where(t => !t.IsDeleted).ToList();
            ViewBag.Authors = _context.Authors.Where(t => !t.IsDeleted).ToList();
            ViewBag.Campaigns = _context.Campaigns.ToList();
            ViewBag.ProductTypes = _context.ProductTypes.Where(t => !t.IsDeleted).ToList();

            string filename = await book.Photo.SaveFile(_env, "assets/img/feature-collection");
            book.ImageUrl = filename;
            book.CreatedTime = DateTime.Now;
            book.IsDeleted = false;
            book.IsSale = true;
            book.BookTags = new List<BookTag>();
            if (book.TagIds != null)
            {
                foreach (var tagId in book.TagIds)
                {
                    BookTag pTag = new BookTag
                    {
                        Book = book,
                        TagId = tagId
                    };
                    _context.BookTags.Add(pTag);
                }
            }
            book.AuthorBooks = new List<AuthorBook>();
            if (book.AuthorIds != null)
            {
                foreach (var authorId in book.AuthorIds)
                {
                    AuthorBook pTag = new AuthorBook
                    {
                        Book = book,
                        AuthorId = authorId
                    };
                    _context.AuthorBooks.Add(pTag);
                }
            }

            book.BookCategories = new List<BookCategory>();
            if (book.CategoryIds != null)
            {
                foreach (var catid in book.CategoryIds)
                {
                    BookCategory pTag = new BookCategory
                    {
                        Book = book,
                        CategoryId = catid
                    };
                    _context.BookCategories.Add(pTag);
                }
            }

            book.BookTypes = new List<BookType>();
            if (book.CategoryIds != null)
            {
                foreach (var typid in book.CategoryIds)
                {
                    BookType pTag = new BookType
                    {
                        Book = book,
                        ProductTypeId = typid
                    };
                    _context.BookTypes.Add(pTag);
                }
            }



            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Tags = _context.Tags.Where(t => !t.IsDeleted).ToList();
            ViewBag.Categories = _context.Categories.Where(t => !t.IsDeleted).ToList();
            ViewBag.Authors = _context.Authors.Where(t => !t.IsDeleted).ToList();
            ViewBag.Campaigns = _context.Campaigns.ToList();
            ViewBag.ProductTypes = _context.ProductTypes.Where(t => !t.IsDeleted).ToList();

            Book b = _context.Books.Find(id);
            if (b == null)
            {
                return NotFound();
            }
            return View(b);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int? id, Book book)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Tags = _context.Tags.Where(t => !t.IsDeleted).ToList();
            ViewBag.Categories = _context.Categories.Where(t => !t.IsDeleted).ToList();
            ViewBag.Authors = _context.Authors.Where(t => !t.IsDeleted).ToList();
            ViewBag.Campaigns = _context.Campaigns.ToList();
            ViewBag.ProductTypes = _context.ProductTypes.Where(t => !t.IsDeleted).ToList();

            Book db = _context.Books.Find(id);
            if (db == null)
            {
                return NotFound();
            }
            if (book.Photo != null)
            {

                if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    return View();
                }

                if (!book.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Sekil Formati secin");
                }

                if (book.Photo.CheckSize(20000))
                {
                    ModelState.AddModelError("Photo", "Sekil 20 mb-dan boyuk ola bilmez");
                }
                Helper.DeleteFile(_env, "assets/img/feature-collection", db.ImageUrl);
                string filename = await book.Photo.SaveFile(_env, "assets/img/feature-collection");
                db.ImageUrl = filename;
            }
            else
            {
                db.ImageUrl = db.ImageUrl;
            }
            Book existName = _context.Books.FirstOrDefault(x => x.Name.ToLower() == book.Name.ToLower());

            if (existName != null)
            {
                if (db != existName)
                {
                    ModelState.AddModelError("Name", "Name Already Exist");
                    return View();
                }
            }
            if (book.CampaignId == 0)
            {
                book.CampaignId = null;

            }
            db.CampaignId = book.CampaignId;
            db.Name = book.Name;
            db.Price = book.Price;
            db.Stock = book.Stock;
            db.Description = book.Description;
            db.UpdatedTime = DateTime.Now;
            var existTags = _context.BookTags.Where(x => x.BookId == book.Id && !x.IsDeleted).ToList();
            if (book.TagIds != null)
            {
                foreach (var tagId in book.TagIds)
                {
                    var existTag = existTags.FirstOrDefault(x => x.TagId == tagId);
                    if (existTag == null)
                    {
                        BookTag bookTag = new BookTag
                        {
                            BookId = book.Id,
                            TagId = tagId,
                        };

                        _context.BookTags.Add(bookTag);
                    }
                    else
                    {
                        existTags.Remove(existTag);
                    }
                }

            }
            _context.BookTags.RemoveRange(existTags);


            var existAuthors = _context.AuthorBooks.Where(x => x.BookId == book.Id && !x.IsDeleted).ToList();
            if (book.AuthorIds != null)
            {
                foreach (var authorId in book.AuthorIds)
                {
                    var existAuthor = existAuthors.FirstOrDefault(x => x.AuthorId == authorId);
                    if (existAuthor == null)
                    {
                        AuthorBook authorBook = new AuthorBook
                        {
                            BookId = book.Id,
                            AuthorId = authorId,
                        };

                        _context.AuthorBooks.Add(authorBook);
                    }
                    else
                    {
                        existAuthors.Remove(existAuthor);
                    }
                }

            }
            _context.AuthorBooks.RemoveRange(existAuthors);

            var existCategories = _context.BookCategories.Where(x => x.BookId == book.Id && !x.IsDeleted).ToList();
            if (book.CategoryIds != null)
            {
                foreach (var categoryId in book.CategoryIds)
                {
                    var existCategory = existCategories.FirstOrDefault(x => x.CategoryId == categoryId);
                    if (existCategory == null)
                    {
                        BookCategory bookCategory = new BookCategory
                        {
                            BookId = book.Id,
                            CategoryId = categoryId,
                        };

                        _context.BookCategories.Add(bookCategory);
                    }
                    else
                    {
                        existCategories.Remove(existCategory);
                    }
                }

            }
            _context.BookCategories.RemoveRange(existCategories);

            var existTypes = _context.BookTypes.Where(x => x.BookId == book.Id && !x.IsDeleted).ToList();
            if (book.BookTypeIds != null)
            {
                foreach (var typeId in book.BookTypeIds)
                {
                    var existType = existTypes.FirstOrDefault(x => x.ProductTypeId == typeId);
                    if (existType == null)
                    {
                        BookType bookCategory = new BookType
                        {
                            BookId = book.Id,
                            ProductTypeId = typeId,
                        };

                        _context.BookTypes.Add(bookCategory);
                    }
                    else
                    {
                        existTypes.Remove(existType);
                    }
                }

            }
            _context.BookTypes.RemoveRange(existTypes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Book book = _context.Books.Where(b => !b.IsDeleted).FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
    }
}
