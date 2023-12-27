using Microsoft.AspNetCore.Mvc;

namespace Routing_Concept.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        // https://localhost:7065/Home/
        // https://localhost:7065/
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        // https://localhost:7065/Home/Welcome
        [Route("[action]")]
        public IActionResult Welcome()
        {
            return View();
        }
        
        // https://localhost:7065/Home/DisplayNumber/2
        [Route("[action]/{id}")]
        public int DisplayNumber(int? id)   // int? indicates that the value can be Nullable
        {
            return id ?? 10;    // ?? checks if NULL, if NULL then return 10 else return the id
        }

    }
}
