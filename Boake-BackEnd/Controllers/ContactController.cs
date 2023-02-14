using Boake_BackEnd.DAL;
using Boake_BackEnd.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Boake_BackEnd.Controllers
{
    public class ContactController : Controller
    {


        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public ContactController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            ViewBag.ContactInfo = _context.ContactInfo.FirstOrDefault();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Contact msg)
        {
            if (!ModelState.IsValid) return View();
            Contact contact = new Contact
            {
                Id = msg.Id,
                Name = msg.Name,
                Subject = msg.Subject,
                Email = msg.Email,
                Message=msg.Message,
                Date = DateTime.Now,
            };

            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return RedirectToAction("index", "contact");

        }
    }
}
