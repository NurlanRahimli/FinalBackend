using Boake_BackEnd.DAL;
using Boake_BackEnd.Helpers;
using Boake_BackEnd.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Linq;
using Boake_BackEnd.Extensions;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace Boake_BackEnd.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "SuperAdmin")]

    public class BioController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BioController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            Bio blogs = _context.Bio.Where(b => !b.IsDeleted).FirstOrDefault();
            return View(blogs);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bio db = _context.Bio.Find(id);
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
        public async Task<IActionResult> Create(Bio Bio)
        {
            if (ModelState["WhitePhotoFile"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!Bio.WhitePhotoFile.IsImage())
            {
                ModelState.AddModelError("WhitePhotoFile", "Sekil Formati secin");
            }

            if (Bio.WhitePhotoFile.CheckSize(20000))
            {
                ModelState.AddModelError("WhitePhotoFile", "Sekil 20 mb-dan boyuk ola bilmez");
            }

            

            if (ModelState["WhitePhotoMediumFile"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!Bio.WhitePhotoMediumFile.IsImage())
            {
                ModelState.AddModelError("WhitePhotoMediumFile", "Sekil Formati secin");
            }

            if (Bio.WhitePhotoMediumFile.CheckSize(20000))
            {
                ModelState.AddModelError("WhitePhotoMediumFile", "Sekil 20 mb-dan boyuk ola bilmez");
            }
            string filename = await Bio.WhitePhotoFile.SaveFile(_env, "assets/img");
            Bio.WhiteLogo = filename;
            string filename2 = await Bio.WhitePhotoMediumFile.SaveFile(_env, "assets/img");
            Bio.WhiteLogoMedium = filename2;

            Bio.CreatedTime = DateTime.Now;

            _context.Bio.Add(Bio);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bio Bio = _context.Bio.Find(id);
            if (Bio == null)
            {
                return NotFound();
            }
            return View(Bio);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int? id, Bio Bio)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (ModelState["WhitePhotoFile"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!Bio.WhitePhotoFile.IsImage())
            {
                ModelState.AddModelError("WhitePhotoFile", "Sekil Formati secin");
            }

            if (Bio.WhitePhotoFile.CheckSize(20000))
            {
                ModelState.AddModelError("WhitePhotoFile", "Sekil 20 mb-dan boyuk ola bilmez");
            }



            if (ModelState["WhitePhotoMediumFile"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!Bio.WhitePhotoMediumFile.IsImage())
            {
                ModelState.AddModelError("WhitePhotoMediumFile", "Sekil Formati secin");
            }

            if (Bio.WhitePhotoMediumFile.CheckSize(20000))
            {
                ModelState.AddModelError("WhitePhotoMediumFile", "Sekil 20 mb-dan boyuk ola bilmez");
            }

            Bio db = _context.Bio.Find(id);
            if (db == null)
            {
                return NotFound();
            }
            Helper.DeleteFile(_env, "assets/img", db.WhiteLogoMedium);
            Helper.DeleteFile(_env, "assets/img", db.WhiteLogo);
            string filename = await Bio.WhitePhotoMediumFile.SaveFile(_env, "assets/img");
            string filename2 = await Bio.WhitePhotoFile.SaveFile(_env, "assets/img");

            

            db.WhiteLogoMedium = filename;
            db.WhiteLogo = filename2;
            db.Facebook = Bio.Facebook;
            db.Twitter = Bio.Twitter;
            db.Instagram = Bio.Instagram;
            db.YouTube = Bio.YouTube;
            db.Pinterest = Bio.Pinterest;
            db.Phone = Bio.Phone; 
            db.Description = Bio.Description;
            db.UpdatedTime = DateTime.Now;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
