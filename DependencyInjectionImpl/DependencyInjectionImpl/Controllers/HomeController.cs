using Microsoft.AspNetCore.Mvc;
using Services;

namespace DependencyInjectionImpl.Controllers
{
    public class HomeController : Controller
    {
        private readonly CityService _cityService;
        public HomeController()
        {
            _cityService = new CityService();
        }
        [Route("/")]
        public IActionResult Index()
        {
            var cities = _cityService.getCities();
            return View(cities);
        }
    }
}
