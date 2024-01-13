using Microsoft.AspNetCore.Mvc;

namespace NET6_Controllers.Controllers
{
    [Controller]
    // always keep the class public -> this helps AspNetCore to instantiate object and call the action method -> this happens only if a Controller is registered in Program.cs
    public class HomeController // either keep the name ending with controller for compiler to detect it as a controller
                                // OR keep the [Controller] annotation at the top of class with any class name
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
