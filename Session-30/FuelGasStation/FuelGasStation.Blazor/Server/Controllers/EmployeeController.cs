using FuelGasStation.EF.Repositories;
using FuelGasStation.Model;
using FuelGasStation.Model.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FuelGasStation.Blazor.Shared.Employee;

namespace FuelGasStation.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        readonly IEntityRepo<Employee> _employeeRepo;
        public EmployeeController(IEntityRepo<Employee> employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeListDto>> Get()
        {
            var result = _employeeRepo.GetAll();
            return result.Select(Employee => new EmployeeListDto
            {
                Name= Employee.Name,
                Surname = Employee.Surname,
                DateHireStart= Employee.DateHireStart,
                DateHireEnd= Employee.DateHireEnd,
                SalaryPerMonth= Employee.SalaryPerMonth,
                EmployeeType = Employee.EmployeeType
            });
        }

        [HttpGet("{id}")]
        public async Task<EmployeeEditDto> GetById(int id)
        {
            var result = _employeeRepo.GetById(id);
            return new EmployeeEditDto
            {

                Name = result.Name,
                Surname = result.Surname,
                DateHireStart = result.DateHireStart,
                DateHireEnd = result.DateHireEnd,
                SalaryPerMonth = result.SalaryPerMonth,
                EmployeeType = result.EmployeeType

            };
        }

        [HttpPost]
        public async Task Post(EmployeeEditDto employee)
        {
            var newEmployee = new Employee(employee.Name, employee.DateHireStart, employee.SalaryPerMonth, employee.EmployeeType)
            {
                Surname= employee.Surname,
                DateHireEnd = employee.DateHireEnd
            };
          
            _employeeRepo.Add(newEmployee);
        }

        [HttpPut]
        public async Task Put(EmployeeEditDto employee)
        {
            var itemToUpdate = _employeeRepo.GetById(employee.Id);
            itemToUpdate.Name = employee.Name;
            itemToUpdate.Surname = employee.Surname; 
            itemToUpdate.DateHireStart= employee.DateHireStart;
            itemToUpdate.DateHireEnd= employee.DateHireEnd;
            itemToUpdate.SalaryPerMonth = employee.SalaryPerMonth;
            itemToUpdate.EmployeeType = employee.EmployeeType;
            _employeeRepo.Update(employee.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
                _employeeRepo.Delete(id);
                return Ok();
        }
    }
}
