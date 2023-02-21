using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelGasStation.Model.Enums;

namespace FuelGasStation.Model
{
    public class Item
    {
        public Item(int code, string descriptioon, ItemType itemType, decimal cost, decimal price)
        {
            Code = code;
            Descriptioon = descriptioon;
            ItemType = itemType;
            Cost = cost;
            Price = price;
            TransactionLines = new List<TransactionLine>();
        }

        public int Id { get; set; }
        public int Code { get; set; }
        public string Descriptioon { get; set; }
        public ItemType ItemType { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }

        //Relations
        public List<TransactionLine> TransactionLines { get; set; }
    }
}
