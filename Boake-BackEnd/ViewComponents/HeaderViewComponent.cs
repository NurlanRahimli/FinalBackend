using Boake_BackEnd.DAL;
using Boake_BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Boake_BackEnd.ViewComponents
{
    public class HeaderViewComponent: ViewComponent
    {
        private AppDbContext _context;

        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.Bio = _context.Bio.FirstOrDefault();
            return View(await Task.FromResult(ViewBag.Bio));
        }
    }
}
