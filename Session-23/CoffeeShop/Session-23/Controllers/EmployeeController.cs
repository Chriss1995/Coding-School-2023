using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using Session_23.Models.Employee;
using CoffeeShop.Model.Enums;

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
            var viewEmployee = new EmployeeDetailsDto
            {
                Id = employees.Id,
                Name = employees.Name,
                Surname = employees.Surname,
                SalaryPerMonth = employees.SalaryPerMonth,
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
        public ActionResult Create(EmployeeCreateDto employees)
        {
            if (!ModelState.IsValid)
            {
                return View(); 
            }
            var dbEmpoloyees = new Employee(employees.Name, employees.Surname, employees.SalaryPerMonth, employees.EmployeeType);
            _employeeRepo.Add(dbEmpoloyees);
            return RedirectToAction("Index");
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbEmployee = _employeeRepo.GetByID(id);
            if(dbEmployee == null)
            {
                return NotFound();
            }
            var viewEmployee = new EmployeeEditDto
            {
                Name= dbEmployee.Name,
                Surname= dbEmployee.Surname,
                Id=dbEmployee.Id,
                SalaryPerMonth= dbEmployee.SalaryPerMonth,
                EmployeeType= dbEmployee.EmployeeType
            };
            return View(model:viewEmployee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EmployeeEditDto employee)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbEmployee = _employeeRepo.GetByID(id);
            if(dbEmployee == null)
            {
                return NotFound();
            }
            dbEmployee.Surname = employee.Surname;
            dbEmployee.SalaryPerMonth = employee.SalaryPerMonth;
            dbEmployee.Name = employee.Name;
            dbEmployee.EmployeeType = employee.EmployeeType;
            _employeeRepo.Update(id, dbEmployee);
            return RedirectToAction(nameof(Index));
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbEmployee= _employeeRepo.GetByID(id);
            if (dbEmployee == null)
            {
                return NotFound();
            }
            var viewEmployee = new EmployeeDeleteDto
            {
                Id = dbEmployee.Id,
                Name = dbEmployee.Name,
                SalaryPerMonth = dbEmployee.SalaryPerMonth,
                Surname = dbEmployee.Surname
            };
            return View(model: viewEmployee);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _employeeRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
