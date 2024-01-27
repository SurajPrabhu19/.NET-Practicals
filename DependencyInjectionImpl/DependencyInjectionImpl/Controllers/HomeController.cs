using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Services;
using ServicesContracts;

namespace DependencyInjectionImpl.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICityService _cityService1;
        private readonly ICityService _cityService2;
        private readonly ICityService _cityService3;
        private readonly IServiceScopeFactory _serviceScopeFactory;
        public HomeController(ICityService cityService1, ICityService cityService2, ICityService cityService3, IServiceScopeFactory serviceScopeFactory)
        {
            _cityService1 = cityService1;
            _cityService2 = cityService2;
            _cityService3 = cityService3;
            _serviceScopeFactory = serviceScopeFactory;
        }
        [Route("/")]
        public IActionResult Index()
        {
            var cities = _cityService1.getCities();

            ViewBag.guid1 = _cityService1.getUniqueId();
            ViewBag.guid2 = _cityService2.getUniqueId();
            ViewBag.guid3 = _cityService3.getUniqueId();
            // creating a scoped city service:
            using(IServiceScope scope = _serviceScopeFactory.CreateScope())
            {
                ICityService service = scope.ServiceProvider.GetRequiredService<ICityService>();
                ViewBag.guid4 = service.getUniqueId();
            }
            // the city service will automatically call the dispose()
            return View(cities);
        }
    }
}
