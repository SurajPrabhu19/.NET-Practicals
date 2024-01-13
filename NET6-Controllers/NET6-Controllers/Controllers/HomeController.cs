using Microsoft.AspNetCore.Mvc;

// Responsibilties of Controllers:
// Reading requests
// Validation of incoming request
// Involing models -> calling business logic methods/ services
// Preparing Response and its type

namespace NET6_Controllers.Controllers
{
    [Controller]
    // always keep the class public -> this helps AspNetCore to instantiate object and call the action method -> this happens only if a Controller is registered in Program.cs
    public class HomeController :  Microsoft.AspNetCore.Mvc.Controller
    // either keep the name ending with controller for compiler to detect it as a controller
    // OR keep the [Controller] annotation at the top of class with any class name
    // Optionally: 1. keep the class public, 2. Inherit from Microsoft.AspNetCore.Mvc.Controller   
    {


        // Attrb based routing:
        [Route("/")]
        [Route("/Index")]
        [Route("/Home")]
        public string Index()
        {
            return "New Controller";
        }
        [Route("returnContentResult")]
        public ContentResult ReturnContentResult()
        {
            //return new ContentResult() { Content = "Inside ReturnContentResult() - way1", ContentType = "text/json" };
            return Content("Inside ReturnContentResult() - way2", "text/json");
        }
    }
}
