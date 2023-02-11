using CoffeeShop.Model;

namespace Session_23.Models.Product
{
    public class ProductCreateDto
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int ProductCategoryID { get; set; }
        public List<TransactionLine>? TransactionLines { get; set; }

        
    }
}
