using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelGasStation.Model
{
    public class TransactionLine
    {
        public TransactionLine(int quantity, decimal itemPrice, decimal metValue, decimal percentDiscount, decimal discountValue, decimal totalValue)
        {
            Quantity = quantity;
            ItemPrice = itemPrice;
            NetValue = metValue;
            PercentDiscount = percentDiscount;
            DiscountValue = discountValue;
            TotalValue = totalValue;
        }
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal NetValue { get; set; }
        public decimal PercentDiscount { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }

        // Relations
        public int TransactionID { get; set; }
        public Transaction Transaction { get; set; } = null!;

        public int ItemID { get; set; }
        public Item Item { get; set; } = null!;
    }
}
