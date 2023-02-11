using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Model;
using CoffeeShop.EF.Context;
using CoffeeShop.Model.Enums;

namespace CoffeeShop.EF.Repositories
{
    public class ProductCategoryRepo
    {
        public void Add(ProductCategory category)
        {
            using var context = new CoffeeShopDbContext();
            context.Add(category);
            context.SaveChanges();
        }
        public void Delete(int id )
        {
            using var context = new CoffeeShopDbContext();
            var dbProductCategory = context.ProductCategories.Where(ProductCategory => ProductCategory.Id == id).SingleOrDefault();
            if (dbProductCategory is null)
                return;
            context.ProductCategories.Remove(dbProductCategory);
            context.SaveChanges();
        }
        public List<ProductCategory> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            return context.ProductCategories.ToList();
        }
        public ProductCategory? GetByID(int id)
        {
            using var context = new CoffeeShopDbContext();
            return context.ProductCategories.Where(ProductCategory => ProductCategory.Id == id)
                .SingleOrDefault();
        }

        public void Update(int id, ProductCategory productCategory)
        {
            using var context = new CoffeeShopDbContext();
            var dbProductCategory = context.ProductCategories.Where(ProductCategory=> ProductCategory.Id == id).SingleOrDefault();
            if (dbProductCategory is null) 
                return;
            dbProductCategory.Code = productCategory.Code;
            dbProductCategory.Description = productCategory.Description;
            dbProductCategory.ProductType = productCategory.ProductType;
            context.SaveChanges();
        }
    }
}
