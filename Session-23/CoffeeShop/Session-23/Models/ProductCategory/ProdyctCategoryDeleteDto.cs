using CoffeeShop.Model.Enums;
using CoffeeShop.Model;
using System.ComponentModel.DataAnnotations;

namespace Session_23.Models.ProductCategory
{
    public class ProdyctCategoryDeleteDto
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ProductType ProductType { get; set; }
        public List<Transaction>? Transactions { get; set; }

    }
}
