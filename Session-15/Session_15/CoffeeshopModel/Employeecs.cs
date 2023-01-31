using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeshopModel
{ public enum EmployeeType
    {
        Manager,
        Cashie,
        Barista,
        Waiter
      }
    public class Employee
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public EmployeeType TypeofEmployee { get; set; }
        public decimal SalaryPerMonth { get; set; }
        public Employee()
        {
            ID = Guid.NewGuid();
        }
    }
    
}
