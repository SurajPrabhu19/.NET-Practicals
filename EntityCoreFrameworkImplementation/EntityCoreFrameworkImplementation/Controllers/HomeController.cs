using EntityCoreFrameworkImplementation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EntityCoreFrameworkImplementation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentDbContext _studentDbContext;    // adding dbcontext using ctor dependency injection

        public HomeController(ILogger<HomeController> logger, StudentDbContext studentDbContext)
        {
            _logger = logger;
            _studentDbContext = studentDbContext;
        }

        public IActionResult Index()
        {
            return View();
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
