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
            if (emp == null) return NotFound();

            TempData["status"] = "Operation Unsuccessful!";

            if (ModelState.IsValid)
            {
                employeeModelDbContext.Employee.Add(emp);
                await employeeModelDbContext.SaveChangesAsync();
                TempData["status"] = "Data Created";
            }

            return RedirectToAction(controllerName: "Employee", actionName: "Index");
        }

        [HttpGet]
        public async Task<IActionResult> Details()
        {
            var employee = await employeeModelDbContext.Employee.FirstOrDefaultAsync<EmployeeModel>();

            return View(employee);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            TempData["status"] = "Operation Unsuccessful!";

            if (id == null || employeeModelDbContext.Employee == null)
                return NotFound();
            var employee = await employeeModelDbContext.Employee.FindAsync(id);

            if (employee == null) return NotFound();

            return View(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, EmployeeModel employee)
        {
            if (id != employee.Id) return NotFound();

            if (ModelState.IsValid)
            {
                employeeModelDbContext.Update(employee);
                await employeeModelDbContext.SaveChangesAsync();
                TempData["status"] = "Data Edited";
            }
            return RedirectToAction(controllerName: "Employee", actionName: "Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            TempData["status"] = "Operation Unsuccessful!";

            if (id == null || employeeModelDbContext.Employee == null) return NotFound();

            var employee = await employeeModelDbContext.Employee.FirstOrDefaultAsync(emp => emp.Id == id);

            if (employee == null) return NotFound();


            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var employee = employeeModelDbContext.Employee.FirstOrDefault(emp => emp.Id == id);

            if (employee != null)
            {
                employeeModelDbContext.Employee.Remove(employee);
                await employeeModelDbContext.SaveChangesAsync();
                TempData["status"] = "Data Deleted";
            }
            return RedirectToAction(controllerName: "Employee", actionName: "Index");
        }
    }
}
