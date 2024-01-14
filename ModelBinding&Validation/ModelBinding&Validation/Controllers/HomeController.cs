using Microsoft.AspNetCore.Mvc;

namespace ModelBinding_Validation.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        [Route("{id?}/{isLoggedIn?}")]
        public IActionResult Index([FromQuery]int? id, [FromQuery]bool? isLoggedIn=false)
        {
            if(id.HasValue == false)
                return BadRequest("Id is Null -> Please pass some Id value");

            if (isLoggedIn == false)
                return Unauthorized("Please login with a valid account");

            return Content("Index Page");
        }
    }
}
