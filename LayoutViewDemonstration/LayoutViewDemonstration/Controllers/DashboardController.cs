using Microsoft.AspNetCore.Mvc;

namespace LayoutViewDemonstration.Controllers
{
    [Route("[controller]/[action]")]
    public class DashboardController : Controller
    {
        [Route("~/[controller]")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("{role?}")]
        public IActionResult login(string? role) {
            if (role != null)
                ViewData["UserRole"] = role;
            else
                ViewData["UserRole"] =  "regular";

            ViewBag.data1 = "ViwwBag data 1";
            ViewBag.data2 = "ViewBag data 2";
            ViewBag.arr = new List<string>();
            
            return View();
        }
        public IActionResult Welcome() {
            return View();
        }
    }
}
