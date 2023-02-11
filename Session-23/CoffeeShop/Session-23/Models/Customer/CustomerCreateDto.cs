using CoffeeShop.Model;

namespace Session_23.Models.Customer
{
    public class CustomerCreateDto
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
