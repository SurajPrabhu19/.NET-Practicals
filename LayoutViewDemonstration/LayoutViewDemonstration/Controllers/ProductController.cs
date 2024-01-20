using Microsoft.AspNetCore.Mvc;

namespace LayoutViewDemonstration.Controllers
{
    public class ProductController : Controller
    {
        [Route("/products-page")]
        public IActionResult Products()
        {
            return View();
        }
        [Route("/order-product")]
        public IActionResult Orders()
        {
            return View();
        }
        [Route("/search-product")]
        public IActionResult Search()
        {
            return View();
        }
    }
}
