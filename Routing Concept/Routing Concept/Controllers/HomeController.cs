using Microsoft.AspNetCore.Mvc;

namespace Routing_Concept.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
