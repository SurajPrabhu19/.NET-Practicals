using EntityCoreFrameworkImplementation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace EntityCoreFrameworkImplementation.Controllers
{
    [Route("[controller]/[action]")]
    public class EmployeeController : Controller
    {
        private readonly EmployeeModelDbContext employeeModelDbContext;

        public EmployeeController(EmployeeModelDbContext employeeModelDbContext)
        {
            this.employeeModelDbContext = employeeModelDbContext;
        }
        public IActionResult Index()
        {
            var employees = employeeModelDbContext.Employee.ToList();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(EmployeeModel emp)
        {
            if(ModelState.IsValid)
            {
                employeeModelDbContext.Employee.Add(emp);
                await employeeModelDbContext.SaveChangesAsync();
                return RedirectToAction(controllerName: "Employee", actionName:"Index");
            }

            return View(emp);
        }
        
        [HttpGet]
        public async Task<IActionResult> Details()
        {
            var employee = await employeeModelDbContext.Employee.FirstOrDefaultAsync<EmployeeModel>();

            return View(employee);
        }

        public async Task<IActionResult> Edit(int id)
        {

            if (id == null || employeeModelDbContext.Employee == null)
                return NotFound();
            var employee = await employeeModelDbContext.Employee.FindAsync(id);

            return View(employee);
        }
    }
}
