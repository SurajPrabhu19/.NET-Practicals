using Microsoft.AspNetCore.Mvc;
using ModelsImplementation.Models;

namespace ModelsImplementation.Controllers
{
    [Route("[controller]")]
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<StudentModel> students = new List<StudentModel>() {
                new StudentModel{id=1, age=23, name="suraj", email="s@gmail.com"},
                new StudentModel{id=2, age=23, name="prabhu", email="p@gmail.com"},
                new StudentModel{id=3, age=24, name="nitya", email="s@gmail.com"},
            };

            ViewData["studs"] = students;

            return View();
        }
    }
}
