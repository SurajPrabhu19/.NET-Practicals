using Microsoft.AspNetCore.Mvc;

namespace Routing_Concept.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        // https://localhost:7065/Home/
        // https://localhost:7065/
        [Route("")]
        [Route("~/")]
        //[Route("~/[controller]")]
        public IActionResult Index()
        {
            return View();
        }

        // https://localhost:7065/Home/Welcome
        public IActionResult Welcome()
        {
            return View();
        }
        
        // https://localhost:7065/Home/DisplayNumber/2
        [Route("{id?}")]    // adding id? indicates that the id is OPTIONAL
        public int DisplayNumber(int? id)   // int? indicates that the value can be Nullable
        {
            return id ?? 10;    // ?? checks if NULL, if NULL then return 10 else return the id
        }

    }
}
