using FuelGasStation.Blazor.Shared.Employee;
using FuelGasStation.Blazor.Shared.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelGasStation.Blazor.Shared.MonthlyLedger
{
    public class MonthlyLedgerDto
    {
        public decimal Expenses { get; set; }
        public decimal Income { get; set; }
        public decimal Total { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public List<TransactionListDto> Transactions { get; set; } =new List<TransactionListDto>();
        public List<EmployeeListDto> Employees { get; set; } =new List<EmployeeListDto>();
    }
}
