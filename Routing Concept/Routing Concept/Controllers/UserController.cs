using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System.Security.Policy;

namespace Routing_Concept.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public int Age(int? age)
        {
            return age ?? 1;    // checks if age == null -> if(true) return 1; else return age
        }

    }
}
