using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelGasStation.Model.Enums;

namespace FuelGasStation.Model
{
    public class Transaction
    {
        public Transaction(decimal totalValue, PaymentMetod paymentMetod) 
        {
            DateTime =  DateTime.Now;
            TotalValue = totalValue;
            PaymentMetod = paymentMetod;
            TransactionLines = new List<TransactionLine>();
        }
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public PaymentMetod PaymentMetod { get; set; }
        public decimal TotalValue { get; set; }

        //Relations
        public int CustomerID { get; set; }
        public Customer Customer { get; set; } = null!;

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; } = null!;

        public List<TransactionLine > TransactionLines { get; set; }
    }
}
