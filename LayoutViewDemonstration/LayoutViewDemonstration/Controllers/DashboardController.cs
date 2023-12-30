using Microsoft.AspNetCore.Mvc;

namespace LayoutViewDemonstration.Controllers
{
    [Route("[controller]/[action]")]
    public class DashboardController : Controller
    {
        [Route("~/[controller]")]
        public IActionResult Index()
        {
            TempData.Keep("NumArr");
            TempData.Keep("Msg");
            return View();
        }

        [Route("{role?}")]
        public IActionResult login(string? role) {
            if (role != null)
                ViewData["UserRole"] = role;
            else
                ViewData["UserRole"] =  "regular";

            // ViewBag & ViewData Implementation: ------------------------------
            ViewBag.data1 = "ViwwBag data 1";
            ViewBag.data2 = "ViewBag data 2";
            ViewBag.arr = new List<string>();

            // TEMP Data Implementation: ------------------------------
            ViewData["Name"] = "Suraj Prabhu";
            ViewBag.LoginTime = DateTime.Now;
            TempData["Msg"] = "User Logged in at" + ViewBag.LoginTime;
            TempData.Keep();
            TempData["NumArr"] = new List<String>() { "num1", "num2", "num3"};
            TempData.Keep();

            return View();
        }
        public IActionResult Welcome() {

            TempData.Keep("NumArr");
            TempData.Keep("Msg");   // Avoid using repeated Keep();
            ViewData["TempArr"] = TempData["NumArr"];
            return View();
        }
    }
}
