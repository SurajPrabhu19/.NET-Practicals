using DBFirst_EntityFramework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DBFirst_EntityFramework.Controllers
{
    [Route("[controller]/[action]")]
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
            return RedirectToAction("List", "Employee");
        }

        [HttpGet]
        public IActionResult List()
        {
            var employees = _dbContext.Employees.ToList();
            return View(employees);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _dbContext.Employees == null)
                return NotFound();

            var employee = await _dbContext.Employees.FirstOrDefaultAsync(emp => emp.Id == id);

            if (employee == null)
                return NotFound();

            return View(employee);
        }
    }
}
