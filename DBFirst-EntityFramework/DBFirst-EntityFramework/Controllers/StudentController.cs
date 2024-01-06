using DBFirst_EntityFramework.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBFirst_EntityFramework.Controllers
{
    public class StudentController : Controller
    {
        private readonly ProgramentorDbFirstContext _dbcontext;

        public StudentController(ProgramentorDbFirstContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            var students = _dbcontext.Students.ToList<Student>();
            return View(students);
        }
    }
}
