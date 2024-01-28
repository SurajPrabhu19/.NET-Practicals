using Microsoft.AspNetCore.Mvc;

namespace environments.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public HomeController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;   // using DI in ctor to get concrete object of Default direct class implementing IWebHostEnvironment
        }


        [Route("/")]
        public IActionResult Index()
        {
            var env = _webHostEnvironment.EnvironmentName;
            ViewBag.EnvironmentName = env;

            return View();
        }
        [Route("/other")]
        public IActionResult Index1()
        {
            return View();
        }

        [Route("/app")]
        public IActionResult RedirectToAppBasedOnEnv()
        {
            var currentEnv = _webHostEnvironment.EnvironmentName;
            string user = "Suraj_Prabhu";
            return RedirectToAction(actionName: "App1", new { env = currentEnv, username = user });
        }

        [Route("app/{env}/{username}")]
        public IActionResult App1(string env, string username)
        {
            ViewBag.userName = username;

            if (env.Equals("Production", StringComparison.OrdinalIgnoreCase))
                return View("ProdApp");
            else if (_webHostEnvironment.IsDevelopment() || env.Equals("Staging"))
                return View("NonProdApp");

            return NotFound();
        }
    }
}
