using Microsoft.AspNetCore.Mvc;
using ModelBindingAndValidation.Models;

namespace ModelBindingAndValidation.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Index(StudentModel s)
        {
            return s+"";
        }
    }
}
