using Microsoft.AspNetCore.Mvc;
using ModelsImplementation.Models;
using ModelsImplementation.Repositories.Contracts;
using ModelsImplementation.Repositories.Data;
using System.Diagnostics;


namespace ModelsImplementation.Controllers
{
    //[Route("[controller]/")]
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;
        private readonly IStudentRepository _studentRepository;

        public StudentController(ILogger<StudentController> logger, IStudentRepository studentRepository)
        {
            _logger = logger;
            _studentRepository = studentRepository; // new StudentRepository(); // Controller based Dependency Injection
        }

        public IActionResult Index()
        {
            List<StudentModel> students = new List<StudentModel>() {
                new StudentModel{id=1, age=23, name="suraj", email="s@gmail.com"},
                new StudentModel{id=2, age=23, name="prabhu", email="p@gmail.com"},
                new StudentModel{id=3, age=24, name="nitya", email="s@gmail.com"},
            };

            // Passing Model data using ViewBag/Data & TempData
            ViewData["StudentViewData"] = students;
            ViewBag.StudentViewBag = students;
            TempData["StudentTempData"] = students;

            return View();
        }

        public IActionResult StudentData()
        {
            return View();
        }
        public IActionResult StrongTypedViews()
        {
            List<StudentModel> students = new List<StudentModel>() {
                new StudentModel{id=1, age=23, name="suraj", email="s@gmail.com"},
                new StudentModel{id=2, age=23, name="prabhu", email="p@gmail.com"},
                new StudentModel{id=3, age=24, name="nitya", email="s@gmail.com"},
            };
            return View(students[0]);
        }
    }
}
