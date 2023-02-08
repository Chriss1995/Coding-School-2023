using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.EF.Repositories
{
    public class TransactionLineRepo
    {
        public void Add(TransactionLine transactionLine)
        {

            using var context = new CoffeeShopDbContext();
            context.Add(transactionLine);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new CoffeeShopDbContext();
            var dbTrancactionLine = context.TransactionLines.Where(TransactionLine => TransactionLine.Id == id).SingleOrDefault();
            if (dbTrancactionLine is null)
                return;
            context.Remove(dbTrancactionLine);
            context.SaveChanges();
        }
        public void Update(int id,TransactionLine transactionLine)
        {
            using var context = new CoffeeShopDbContext();
            var dbTransanctionLine = context.TransactionLines.Where(TransactionLine => TransactionLine.Id == id).SingleOrDefault();
            if(dbTransanctionLine is null) return;
            dbTransanctionLine.TotalPrice = transactionLine.TotalPrice;
            dbTransanctionLine.Price = transactionLine.Price;
            dbTransanctionLine.Quantity = transactionLine.Quantity;
            dbTransanctionLine.Discount = transactionLine.Discount;
            dbTransanctionLine.Transaction= transactionLine.Transaction;
            dbTransanctionLine.Product= dbTransanctionLine.Product;
            context.SaveChanges();
        }
    }
    
}
