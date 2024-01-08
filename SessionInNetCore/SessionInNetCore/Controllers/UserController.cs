using Microsoft.AspNetCore.Mvc;

namespace SessionInNetCore.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            //return View();
            return RedirectToAction("Dashboard");
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }

    }
}
