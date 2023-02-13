using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Model;
using CoffeeShop.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace CoffeeShop.EF.Repositories
{
    public class ProductRepo
    {
        public void Add(Product product)
        {
            using var context = new CoffeeShopDbContext();
            if (product.Id != 0)
                throw new ArgumentException("Given product should not have Id set");
            context.Add(product);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            using var context = new CoffeeShopDbContext();
            var dbProduct = context.Products.Where(Product => Product.Id == id).SingleOrDefault(Product => Product.Id == id);
            if (dbProduct is null)
                return;
            context.Products.Remove(dbProduct);
            context.SaveChanges();
        }
        public List<Product> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            return context.Products.Include(Product => Product.ProductCategory).ToList();
        }
        public Product? GetByID(int id)
        {
            using var context = new CoffeeShopDbContext();
            return context.Products.Include(Product => Product.ProductCategory).SingleOrDefault(Product => Product.Id == id);
        }
        public void Update(int id, Product product)
        {
            using var context = new CoffeeShopDbContext();
            var dbProduct = context.Products.Where(Product => Product.Id == id).SingleOrDefault(Product => Product.Id == id);
            if (dbProduct is null) return;
            dbProduct.Code = product.Code;
            dbProduct.Description = product.Description;
            dbProduct.Price = product.Price;
            product.Cost = product.Cost;
            product.ProductCategoryId = product.ProductCategoryId;
            context.SaveChanges();
        }
    }
}
