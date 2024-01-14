using Microsoft.AspNetCore.Mvc;

namespace ModelBindingAndValidation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? bookId)
        {
            if(!bookId.HasValue == false)
            {
                return BadRequest("Book id is not provided!");
            }
            return Content("Index Page");
        }
    }
}
