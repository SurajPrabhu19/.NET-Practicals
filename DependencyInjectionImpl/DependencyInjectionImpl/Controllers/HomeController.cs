using Microsoft.AspNetCore.Mvc;
using Services;
using ServicesContracts;

namespace DependencyInjectionImpl.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICityService _cityService1;
        private readonly ICityService _cityService2;
        private readonly ICityService _cityService3;
        public HomeController(ICityService cityService1, ICityService cityService2, ICityService cityService3)
        {
            _cityService1 = cityService1;
            _cityService2 = cityService2;
            _cityService3 = cityService3;
        }
        [Route("/")]
        public IActionResult Index()
        {
            var cities = _cityService1.getCities();

            ViewBag.guid1 = _cityService1.getUniqueId();
            ViewBag.guid2 = _cityService2.getUniqueId();
            ViewBag.guid3 = _cityService3.getUniqueId();

            return View(cities);
        }
    }
}
