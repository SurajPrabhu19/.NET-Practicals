using Microsoft.AspNetCore.Mvc;

namespace environments.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/")]
        public IActionResult Index1()
        {
            return View();
        }
    }
}
