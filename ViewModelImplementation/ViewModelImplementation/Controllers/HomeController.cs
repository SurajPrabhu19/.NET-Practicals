using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewModelImplementation.Models;

namespace ViewModelImplementation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            SchoolViewModel model = new SchoolViewModel();
            model.Students = new List<Student>()
            {   
                new Student(){Id = 1, email="s@gmail.com", Name="Suraj", Std=22},           
                new Student(){Id = 2, email="n@gmail.com", Name="Nitin", Std=23},           
                new Student(){Id = 3, email="sp@gmail.com", Name="Prabhu", Std=23},           
            };
            model.Teachers = new List<Teacher>()
            {
                new Teacher(){Id = 1, Description="abc", Name="Suraj", Gender="Male"},           
                new Teacher(){Id = 2, Description="def", Name="Nitin", Gender="Male"},           
                new Teacher(){Id = 3, Description="hij", Name="Prabhu", Gender="Male"},           
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
