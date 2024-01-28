using Microsoft.AspNetCore.Mvc;

namespace configurations.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            ViewBag.MyKey = _configuration["MyKey"];
            ViewBag.RandomKey = _configuration.GetValue<string>("RandomKey", "Value doesnt exists -> default value added");
            return View();
        }
    }
}
