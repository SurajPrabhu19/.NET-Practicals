using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionImpl.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
