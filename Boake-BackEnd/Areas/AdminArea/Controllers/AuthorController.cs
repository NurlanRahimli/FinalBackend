using Boake_BackEnd.DAL;
using Boake_BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Boake_BackEnd.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "SuperAdmin")]

    public class AuthorController : Controller
    {
        private readonly AppDbContext _context;

        public AuthorController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Author> Authors = await _context.Authors.Where(m => !m.IsDeleted).AsNoTracking().OrderByDescending(m => m.Id).ToListAsync();
            return View(Authors);

        }

        //[Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Author Author)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }


                bool isExist = await _context.Authors.AnyAsync(m => m.Name.Trim() == Author.Name.Trim());

                if (isExist)
                {
                    ModelState.AddModelError("Name", "Author already exist");
                    return View();
                }


                await _context.Authors.AddAsync(Author);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {

                ViewBag.Message = ex.Message;
                return View();
            }

        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Author Author = await _context.Authors.FirstOrDefaultAsync(m => m.Id == id);

            Author.IsDeleted = true;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            try
            {
                if (id is null) return BadRequest();

                Author Author = await _context.Authors.FirstOrDefaultAsync(m => m.Id == id);

                if (Author is null) return NotFound();

                return View(Author);

            }
            catch (Exception ex)
            {

                ViewBag.Message = ex.Message;
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Author Author)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(Author);
                }

                Author dbAuthor = await _context.Authors.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id);

                if (dbAuthor is null) return NotFound();

                if (dbAuthor.Name.ToLower().Trim() == Author.Name.ToLower().Trim())
                {
                    return RedirectToAction(nameof(Index));
                }

                dbAuthor.Name = Author.Name;

                _context.Authors.Update(Author);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }
            catch (Exception ex)
            {

                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
