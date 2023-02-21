using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelGasStation.Model.Enums;

namespace FuelGasStation.Model
{
    public  class Employee
    {
        private EmployeeType employeeType;

        public Employee(string name, string surname, DateTime dateHireStart, int salaryPerMonth, EmployeeType employeeType)
        {
            Name = name;
            Surname = surname;
            DateHireStart = dateHireStart;
            SalaryPerMonth = salaryPerMonth;
            EmployeeType = employeeType;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateHireStart { get; set; }
        public DateTime? DateHireEnd { get; set; }
        public int SalaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}
