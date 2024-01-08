using Microsoft.AspNetCore.Mvc;
using SessionInNetCore.Models;

namespace SessionInNetCore.Controllers
{
    public class UserController : Controller
    {
        private readonly ProgramentorDbFirstContext dbContext;
        public UserController(ProgramentorDbFirstContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            //return View();
            return RedirectToAction("Dashboard");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User tempUser)
        {
            var user = dbContext.Users.Where(row => tempUser.Email.Equals(row.Email) && tempUser.Password.Equals(row.Password)).FirstOrDefault();
            if (user != null)
            {
                HttpContext.Session.SetString("email", user.Email);
                return RedirectToAction("Dashboard");
            }
            ViewData["LoginFailed"] = "Login Failed! Please re-enter your credentials";
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
