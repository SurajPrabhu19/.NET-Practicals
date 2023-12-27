using Microsoft.AspNetCore.Mvc;

namespace Routing_Concept.Controllers
{
    public class HomeController : Controller
    {
        // https://localhost:7065/Home/Welcome
        public IActionResult Welcome()
        {
            return View();
        }

        // https://localhost:7065/Home/DisplayNumber/2
        public int DisplayNumber(int? id)   // int? indicates that the value can be Nullable
        {
            return id ?? 10;
        }

    }
}
