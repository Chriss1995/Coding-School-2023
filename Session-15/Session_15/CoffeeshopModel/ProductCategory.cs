using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeshopModel
{
    internal class ProductCategory
    {public Guid ID { get; set; }
    public int Code { get; set; }
    public string Description { get; set; }
    public ProductCategory()
        {
            ID = Guid.NewGuid();
        }
    }
}
