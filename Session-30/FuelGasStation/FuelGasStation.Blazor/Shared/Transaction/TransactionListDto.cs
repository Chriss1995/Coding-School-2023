using FuelGasStation.Blazor.Shared.Customer;
using FuelGasStation.Blazor.Shared.Employee;
using FuelGasStation.Blazor.Shared.TransactionLine;
using FuelGasStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelGasStation.Blazor.Shared.Transaction
{
    public class TransactionListDto
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public PaymentMethod PaymentMetod { get; set; }
        public decimal TotalValue { get; set; }
        public int CustomerID { get; set; }
        public string CustomerSurname { get; set; } = null!;
        public List<CustomerListDto> Customers { get; set; } = new();
        public int EmployeeID { get; set; }
        public string EmployeeSurname { get; set; } = null!;
        public List<EmployeeListDto> Employees { get; set; } = new();
        public List<TransactionLineListDto> TransactionLines { get; set; } = new();

    }
}
