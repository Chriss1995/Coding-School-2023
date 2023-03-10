using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeshopModel
{
    public class Product
    { public enum ProductType
        {
            Coffee,
            Beverages,
            Food
        }
        public Guid ID { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public int ProductCategoryID { get; set; }
        public ProductType TypeofProduct { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public Product()
        {
            ID = Guid.NewGuid();
        }
    }
}
