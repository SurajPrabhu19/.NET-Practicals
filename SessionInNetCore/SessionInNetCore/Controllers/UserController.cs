using Microsoft.AspNetCore.Mvc;
using SessionInNetCore.Models;

namespace SessionInNetCore.Controllers
{
    public enum Gender
    {
        Male,
        Female,
    }
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
            if (HttpContext.Session.GetString("email") != null)
            {
                return RedirectToAction("Dashboard");
            }
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

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]  
        public IActionResult SignUp(User user)
        {
            if(ModelState.IsValid)
            {
                dbContext.Users.AddAsync(user);
                dbContext.SaveChangesAsync();
                TempData["Register"] = "Registered Successfully";
                return RedirectToAction("Login");
            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("email");
            return RedirectToAction("Login");
        }
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("email") == null)
            {
                return RedirectToAction("Login");
            }
            var users = dbContext.Users.ToList();
            return View(users);
        }

    }
}
