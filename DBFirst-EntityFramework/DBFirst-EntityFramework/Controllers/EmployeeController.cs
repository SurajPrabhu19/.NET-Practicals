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
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            var employees = _dbContext.Employees.ToList();
            return View(employees);
        }
    }
}
