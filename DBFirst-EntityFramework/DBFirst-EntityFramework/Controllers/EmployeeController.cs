using DBFirst_EntityFramework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DBFirst_EntityFramework.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ProgramentorDbFirstContext _dbContext;
        public EmployeeController(ProgramentorDbFirstContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            HttpContext.Session.SetString("username", "Suraj Prabhu");
            HttpContext.Session.SetString("password", "12345");
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            var employees = _dbContext.Employees.ToList();
            return View(employees);
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
