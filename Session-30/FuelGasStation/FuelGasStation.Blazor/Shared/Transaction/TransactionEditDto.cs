using FuelGasStation.Blazor.Shared.Customer;
using FuelGasStation.Blazor.Shared.Employee;
using FuelGasStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelGasStation.Blazor.Shared.Transaction
{
   public class TransactionEditDto
   {
            public int Id { get; set; }
            public DateTime DateTime { get; set; }
            public PaymentMetod PaymentMethod { get; set; }
            public decimal TotalValue { get; set; }
            public int CustomerID { get; set; }
            public string CustomerSurname { get; set; } = null!;
            public List<CustomerListDto> Cutomers { get; set; } = new();
            public int EmployeeID { get; set; }
            public string EmployeeSurname { get; set; } = null!;
            public List<EmployeeListDto> Employees { get; set; } = new();
    }
}
