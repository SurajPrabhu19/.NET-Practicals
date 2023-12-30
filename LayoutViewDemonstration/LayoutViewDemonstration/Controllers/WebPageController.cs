using Microsoft.AspNetCore.Mvc;

namespace LayoutViewDemonstration.Controllers
{
    [Route("page/[action]")]
    public class WebPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        //public IActionResult Dashboard()
        //{
        //    return View();
        //}

    }
}
