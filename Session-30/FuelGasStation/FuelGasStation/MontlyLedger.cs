using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelGasStation.Model
{
    public class MontlyLedger
    {
        public MontlyLedger(int year, int month, IList<Transaction> transactions, IList<Employee> employees)
        {
            Year = year;
            Month = month;
            Transactions = transactions;
            Employees = employees;
        }

        public decimal Exenses { get; set; }
        public decimal Income { get; set; }
        public decimal Total { get; set; }
        public IList<Transaction> Transactions { get; set; } = new List<Transaction>();
        public IList<Employee> Employees { get; set; } = new List<Employee>();
        public int Year { get; set; }
        public int Month { get; set; }
    
    }
}
