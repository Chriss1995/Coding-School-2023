using CoffeeShop.Model;
using CoffeeShop.Model.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Session_23.Models.TransactionLine
{
    public class TransactionLineDetailsDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
        public int TransactionId { get; set; }
        public Transaction? Transaction { get; set; }
        public int ProdctId { get; set; }
        public List<SelectListItem> Prpoduct { get; set; } = new List<SelectListItem>();

    }
}
