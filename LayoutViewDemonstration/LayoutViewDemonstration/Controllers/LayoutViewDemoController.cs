using Microsoft.AspNetCore.Mvc;

namespace LayoutViewDemonstration.Controllers
{
    public class LayoutViewDemoController : Controller
    {
        [Route("/layout")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/contact-page")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("/about-page")]
        public IActionResult About()
        {
            return View();
        }
    }
}
