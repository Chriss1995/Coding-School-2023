using FuelGasStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelGasStation.Blazor.Shared.Employee
{
    public class EmployeeEditDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public DateTime DateHireStart { get; set; }
        public DateTime? DateHireEnd { get; set; }
        public int SalaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
}