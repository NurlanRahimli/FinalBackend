using Boake_BackEnd.DAL;
using Boake_BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Boake_BackEnd.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            About about = _context.Abouts.FirstOrDefault(a=>!a.IsDeleted);
            return View(about);
        }
    }
}
