using Boake_BackEnd.DAL;
using Boake_BackEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Boake_BackEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Books =await _context.Books.Include(b => b.Campaign).Where(s => !s.IsDeleted&& s.IsSale).ToListAsync();

            homeVM.Blogs =await _context.Blog.Include(s=>s.Comments).Where(s => !s.IsDeleted).ToListAsync();
            homeVM.Sliders =await _context.Sliders.Where(s=>!s.IsDeleted).ToListAsync(); 
            return View(homeVM);
        }
    }
}
