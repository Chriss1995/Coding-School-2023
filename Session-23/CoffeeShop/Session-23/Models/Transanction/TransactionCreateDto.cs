using CoffeeShop.Model;
using CoffeeShop.Model.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Session_23.Models.Transanction
{
    public class TransactionCreateDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public int CustomerId { get; set; }
        public List<SelectListItem> Customer { get; set; } =  new List<SelectListItem>();
        public int EmployeeId { get; set; }
        public List<SelectListItem> Employee { get; set; } = new List<SelectListItem>();
    }
}
