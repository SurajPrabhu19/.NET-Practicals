using Microsoft.AspNetCore.Mvc;

namespace LayoutViewDemonstration.Controllers
{
    public class LayoutViewDemoController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("/about")]
        public IActionResult About()
        {
            return View();
        }
    }
}
