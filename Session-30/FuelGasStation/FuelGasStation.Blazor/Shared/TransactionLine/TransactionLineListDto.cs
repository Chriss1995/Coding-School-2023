using FuelGasStation.Blazor.Shared.Item;
using FuelGasStation.Blazor.Shared.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelGasStation.Blazor.Shared.TransactionLine
{
    public class TransactionLineListDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal NetValue { get; set; }
        public decimal PercentDiscount { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }
        public int TransactionID { get; set; }
        public List<TransactionListDto> Transactions { get; set; } = new();
        public string ItemCode { get; set; } = null!;
        public int ItemID { get; set; }
        public List<ItemListDto> Items { get; set; } = new();
    }
}
