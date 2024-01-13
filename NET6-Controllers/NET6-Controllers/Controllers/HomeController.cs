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
            return Content("Inside ReturnContentResult() - way2", "text/json"); // works if class inherits controller
        }
    }
}
// To return Json Object:
/*
 * return new JsonResult(obj);
 * return Json(obj); - if class inherits Mvc.Controller 
 */

// File Result:
/*
 * return new VirtualFileResult("file relative path","content-type"); - use when file is inside static web root folder - works only with web root folder
 * return File("file relative path","content-type");
 * 
 * return new PhysicalFileResult("file absolute path","content-type"); - works inside and outside webroot folder
 * return PhysicalFile("file relative path","content-type");
 * 
 * return new FileContentResult("byte-array","content-type");
 * return File(byte-array","content-type"); - byte[] bytes = System.IO.File.ReadAllBytes(@"c:\aspnetcore\sample.pdf")
 */