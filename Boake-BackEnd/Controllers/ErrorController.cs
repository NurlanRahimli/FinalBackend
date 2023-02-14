using Microsoft.AspNetCore.Mvc;

namespace Boake_BackEnd.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
