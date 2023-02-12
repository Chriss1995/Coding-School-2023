using CoffeeShop.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Session_23.Models.Product
{
    public class ProductDetailsDto
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int ProductCategoryId { get; set; }
        public List<SelectListItem> ProductCategory { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> TransactionLines { get; set; } = new List<SelectListItem>();


    }
}
