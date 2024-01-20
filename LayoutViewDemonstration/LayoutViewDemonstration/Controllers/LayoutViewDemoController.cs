using Microsoft.AspNetCore.Mvc;

namespace LayoutViewDemonstration.Controllers
{
    public class LayoutViewDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
