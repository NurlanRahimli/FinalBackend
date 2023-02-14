using Boake_BackEnd.DAL;
using Boake_BackEnd.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Boake_BackEnd.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    //[Authorize(Roles = "Admin,SuperAdmin")]
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
            List<Contact> contacts = _context.Contacts.ToList();
            return View(contacts);
        }

        public IActionResult Edit(int id)
        {
            Contact contact = _context.Contacts.FirstOrDefault(o => o.Id == id);
            if (contact == null) return NotFound();
            return View(contact);
        }

        public IActionResult Send(int id, string message)
        {
            Contact order = _context.Contacts.FirstOrDefault(o => o.Id == id);
            if (order == null) return Json(new { status = 400 });

            order.Message = message;
            _context.SaveChanges();
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("nurlanshr@code.edu.az", "Boake");
            mail.To.Add(new MailAddress(order.Email));

            mail.Subject = "Message";

            string body = string.Empty;

            using (StreamReader reader = new StreamReader("wwwroot/MailTemplate/ContactMessage.html"))
            {
                body = reader.ReadToEnd();
            }
            string aboutText = $"Hello Mr/Mrs ";
            string messageTxt = $"{message}";
            body = body.Replace("{{message}}", messageTxt);
            mail.Body = body.Replace("{{aboutText}}", aboutText);
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("nurlanshr@code.edu.az", "jjnpuvzgmtdtfrlz");
            smtp.Send(mail);
            return Json(new { status = 200 });
        }
    }
}
