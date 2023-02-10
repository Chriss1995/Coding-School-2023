using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using Session_23.Models.Employees;

namespace Session_23.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeRepo _employeeRepo;
        public EmployeeController(EmployeeRepo employee)
        {
            _employeeRepo = employee;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            var employees = _employeeRepo.GetAll();
            var EmployeeList = employees.ToList(); 
            return View(model: EmployeeList);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int? id)
        {   

            if (id == null)
            {
                return NotFound();
            }
            var employees = _employeeRepo.GetByID(id.Value);
            if (employees == null)
            {
                return NotFound();
            }
            var viewEmployee = new EmployeesDetailsDto
            {
                Id = employees.Id,
                Name = employees.Name,
                Surname = employees.Surname,
                SalaryPerMoth = employees.SalaryPerMonth,
                EmployeeType= employees.EmployeeType
            };
            return View(model:viewEmployee);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
