using CoffeeShop.Model.Enums;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Session_23.Models.Employees
{
    public class EmployeesDetailsDto
    {
        public int Id { get; set; }
        [Display (Name = "Name") ]
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public int SalaryPerMoth { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
}
