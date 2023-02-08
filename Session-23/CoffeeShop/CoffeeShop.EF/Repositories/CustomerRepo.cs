using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Model;
using CoffeeShop.EF.Configurations;
using System.Diagnostics.CodeAnalysis;
using CoffeeShop.EF.Context;

namespace CoffeeShop.EF.Repositories
{
    public class CustomerRepo
    {
        public void Add(Customer customer)
        {
            using var context = new CoffeeShopDbContext();
            context.Add(customer);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            using var context = new CoffeeShopDbContext();
            var dbCustomer = context.Customers.Where(Customer => Customer.Id == id).SingleOrDefault();
            if (dbCustomer is null)
                return;
            context.Remove(dbCustomer);
            context.SaveChanges();
        }
        public Customer? GetByID(int id)
        {
            using var context = new CoffeeShopDbContext();
            return context.Customers.Where(Customer => Customer.Id == id)
                .SingleOrDefault();
        }
        public void Update(int id, Customer customer) 
        {
            using var context = new CoffeeShopDbContext();
            var dbCustomer = context.Customers.Where(Customer=> Customer.Id == id).SingleOrDefault();
            if (dbCustomer is null) return;
            dbCustomer.Description = customer.Description;
            dbCustomer.Code = customer.Code;
            context.SaveChanges();
        }
    }
}
