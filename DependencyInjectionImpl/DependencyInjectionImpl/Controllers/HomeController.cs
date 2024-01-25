using Microsoft.AspNetCore.Mvc;
using Services;
using ServicesContracts;

namespace DependencyInjectionImpl.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICityService _cityService;
        public HomeController(ICityService cityService)
        {
            _cityService = cityService;
        }
        [Route("/")]
        public IActionResult Index()
        {
            var cities = _cityService.getCities();
            return View(cities);
        }
    }
}
