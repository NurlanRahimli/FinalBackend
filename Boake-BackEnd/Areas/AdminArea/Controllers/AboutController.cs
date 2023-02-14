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

namespace Boake_BackEnd.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "SuperAdmin")]

    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public AboutController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            About blogs = _context.Abouts.Where(b => !b.IsDeleted).FirstOrDefault();
            return View(blogs);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            About db = _context.Abouts.Find(id);
            if (db == null) return NotFound();
            db.IsDeleted = true;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(About about)
        {
            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!about.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Sekil Formati secin");
            }

            if (about.Photo.CheckSize(20000))
            {
                ModelState.AddModelError("Photo", "Sekil 20 mb-dan boyuk ola bilmez");
            }

            string filename = await about.Photo.SaveFile(_env, "assets/img/about");
            about.ImageUrl = filename;

            about.CreatedTime = DateTime.Now;
             
            _context.Abouts.Add(about);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
             
            About about = _context.Abouts.Find(id);
            if (about == null)
            {
                return NotFound();
            }
            return View(about);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int? id, About about)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Tags = _context.Tags.Where(t => !t.IsDeleted).ToList();

           
            About db = _context.Abouts.Find(id);
            if (db == null)
            {
                return NotFound();
            }
            if (about.Photo != null)
            {

                if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    return View();
                }

                if (!about.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Sekil Formati secin");
                }

                if (about.Photo.CheckSize(20000))
                {
                    ModelState.AddModelError("Photo", "Sekil 20 mb-dan boyuk ola bilmez");
                }
                Helper.DeleteFile(_env, "assets/img/about", db.ImageUrl);
                string filename = await about.Photo.SaveFile(_env, "assets/img/about");
                db.ImageUrl = filename;
            }
            else
            {
                db.ImageUrl = db.ImageUrl;
            } 
            About existName = _context.Abouts.FirstOrDefault(x => x.Name.ToLower() == about.Name.ToLower());

            if (existName != null)
            {
                if (db != existName)
                {
                    ModelState.AddModelError("Name", "Name Already Exist");
                    return View();
                }
            }
             
            db.Name = about.Name;
            db.Description = about.Description;
            db.UpdatedTime = DateTime.Now;
            

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
