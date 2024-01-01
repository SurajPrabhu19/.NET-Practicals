using Microsoft.AspNetCore.Mvc;
using ModelBindingAndValidation.Models;

namespace ModelBindingAndValidation.Controllers
{
    [Route("[controller]/[action]")]
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(StudentModel s)
        {
            ViewData["stud"] = s;
            return View(s);
        }
    }
}
