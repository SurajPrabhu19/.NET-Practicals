using Microsoft.AspNetCore.Mvc;

namespace LayoutViewDemonstration.Controllers
{
    public class ProductController : Controller
    {
        [Route("/products")]
        public IActionResult Products()
        {
            return View();
        }
        [Route("/orders")]
        public IActionResult Orders()
        {
            return View();
        }
        [Route("/search")]
        public IActionResult Search()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
