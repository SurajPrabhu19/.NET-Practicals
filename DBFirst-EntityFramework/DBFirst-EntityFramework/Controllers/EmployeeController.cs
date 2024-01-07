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
            HttpContext.Session.SetString("email", "s@gmail.com");

            TempData["user"] = HttpContext.Session.GetString("username");
            TempData["email"] = HttpContext.Session.GetString("email");

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

        public IActionResult Logout()
        {
            var session = HttpContext.Session;
            if (session.GetString("username") != null || session.GetString("password") != null)
            {
                session.Remove("username");
                session.Remove("password");
            }

            return RedirectToAction("List","Employee");
        }
    }
}
