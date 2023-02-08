using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Model;
using CoffeeShop.EF.Context;
using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.EF.Repositories
{
    public class TransactionRepo
    {
        public void Add(Transaction transaction)
        {
            using var context = new CoffeeShopDbContext();
            context.Add(transaction);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            using var context = new CoffeeShopDbContext();
            var dbTransaction = context.Transactions.Where(Transaction => Transaction.Id == id).SingleOrDefault();
            if (dbTransaction is null)
                return;
            context.Update(dbTransaction);
            context.SaveChanges();
        }
        public List<Transaction> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            return context.Transactions.Include(Transaction => Transaction.TransactionLines)
                .ToList();
        }
        public void Update(int id, Transaction transaction)
        {
            using var context= new CoffeeShopDbContext();
            var dbTransaction = context.Transactions.Where(Transaction=> Transaction.Id == id).SingleOrDefault();
            if (dbTransaction is null) return;
            dbTransaction.Date = DateTime.Now;
            dbTransaction.TotalPrice= transaction.TotalPrice;
            dbTransaction.PaymentMethod= transaction.PaymentMethod;
            dbTransaction.Customer = transaction.Customer;
            dbTransaction.Employee= transaction.Employee;
            context.SaveChanges();
        }
    }
}
