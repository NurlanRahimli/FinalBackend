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

    public class TypeController : Controller
    {
        private readonly AppDbContext _context;

        public TypeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<ProductType> productTypes = await _context.ProductTypes.Where(m => !m.IsDeleted).AsNoTracking().OrderByDescending(m => m.Id).ToListAsync();
            return View(productTypes);

        }

        //[Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductType productType)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }


                bool isExist = await _context.ProductTypes.AnyAsync(m => m.Name.Trim() == productType.Name.Trim());

                if (isExist)
                {
                    ModelState.AddModelError("Name", "Product Type already exist");
                    return View();
                }


                await _context.ProductTypes.AddAsync(productType);

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
            ProductType productType = await _context.ProductTypes.FirstOrDefaultAsync(m => m.Id == id);

            productType.IsDeleted = true;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            try
            {
                if (id is null) return BadRequest();

                ProductType productType = await _context.ProductTypes.FirstOrDefaultAsync(m => m.Id == id);

                if (productType is null) return NotFound();

                return View(productType);

            }
            catch (Exception ex)
            {

                ViewBag.Message = ex.Message;
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProductType productType)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(productType);
                }

                ProductType dbProductType = await _context.ProductTypes.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id);

                if (dbProductType is null) return NotFound();

                if (dbProductType.Name.ToLower().Trim() == productType.Name.ToLower().Trim())
                {
                    return RedirectToAction(nameof(Index));
                }

                dbProductType.Name = productType.Name;

                _context.ProductTypes.Update(productType);

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
