using FuelGasStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelGasStation.Blazor.Shared.Item
{
    public class ItemListDto
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Description { get; set; } = null!;
        public ItemType ItemType { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
    }
}
