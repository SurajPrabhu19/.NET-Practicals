using Microsoft.AspNetCore.Mvc;

namespace MapMethodsRouting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            return View();
        }
    }
}
