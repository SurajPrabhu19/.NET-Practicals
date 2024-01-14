using Microsoft.AspNetCore.Mvc;

namespace ModelBinding_Validation.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        public IActionResult Index(int? id, bool? isLoggedIn=false)
        {
            if(id.HasValue == false)
                return BadRequest("Id is Null -> Please pass some Id value");

            if (isLoggedIn == false)
                return Unauthorized("Please login with a valid account");

            return Content("Index Page");
        }
    }
}
