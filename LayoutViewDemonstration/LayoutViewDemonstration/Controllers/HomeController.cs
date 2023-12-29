using Microsoft.AspNetCore.Mvc;

namespace LayoutViewDemonstration.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        // https://localhost:7065/Home/Index
        public IActionResult Index()
        {
            return View();
        }

        // https://localhost:7065/
        [Route("~/")]
        public IActionResult Welcome()
        {
            return View();
        }
        // https://localhost:7065/Home/RazorCodeImplementation
        public IActionResult RazorCodeImplementation()
        {
            return View();
        }

        // https://localhost:7065/Home
        [Route("~/[controller]")]
        public IActionResult Home()
        {
            return View();
        }
    }
}
