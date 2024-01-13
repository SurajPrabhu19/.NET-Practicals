using Microsoft.AspNetCore.Mvc;

namespace NET6_Controllers.Controllers
{
    // always keep the class public -> this helps AspNetCore to instantiate object and call the action method -> this happens only if a Controller is registered in Program.cs
    public class HomeController // always keep the name ending with controller for compiler to detect it as a controller
    {
        // Attrb based routing:
        [Route("/")]
        [Route("/Index")]
        [Route("/Home")]
        public string Index()
        {
            return "New Controller";
        }
    }
}
