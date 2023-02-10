using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Model;
using CoffeeShop.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.EF.Repositories
{
    public class ProductRepo
    {
        public void Add(Product product)
        {
            using var context = new CoffeeShopDbContext();
            context.Add(product);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            using var context = new CoffeeShopDbContext();
            var dbProduct = context.Products.Where(Product=> Product.Id == id).SingleOrDefault();
            if (dbProduct is null)
                return;
            context.Products.Remove(dbProduct);
            context.SaveChanges();
        }
        public List<Product> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            return context.Products.ToList();
        }
        public Product? GetByID(int id)
        {
            using var context = new CoffeeShopDbContext();
            return context.Products.Where(Product => Product.Id == id).SingleOrDefault();
        }
        public void Update(int id, Product product)
        {
            using var context = new CoffeeShopDbContext();
            var dbProduct = context.Products.Where(Product=> Product.Id == id).SingleOrDefault();
            if (dbProduct is null) return;
            dbProduct.Code = product.Code;
            dbProduct.Description= product.Description;
            dbProduct.Price = product.Price;
            product.Cost = product.Cost;
            product.ProductCategoryId = product.ProductCategoryId;

        }
    }
}
