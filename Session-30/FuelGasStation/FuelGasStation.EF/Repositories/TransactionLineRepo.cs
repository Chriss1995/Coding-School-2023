using FuelGasStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelGasStation.EF.Context;
using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;

namespace FuelGasStation.EF.Repositories
{
    internal class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        public void Add(TransactionLine entity)
        {
            using var context = new FuelGasStationDbContext();
            if (entity.Id != 0) 
            {
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            }
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var ctx = new FuelGasStationDbContext();
            var dbTransactionLine = ctx.TransactionsLine.Where(TransactionLine => TransactionLine.Id == id)
                                        .Include(TransactionLine=> TransactionLine.Transaction)
                                        .Include(TransactionLine=> TransactionLine.Item)
                                        .SingleOrDefault();
            if (dbTransactionLine is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            else
            {
                ctx.Remove(dbTransactionLine);
                ctx.SaveChanges();
            }

        }

        public IList<TransactionLine> GetAll()
        {
            using var db = new FuelGasStationDbContext();
            return db.TransactionsLine.Include(TransactionLine => TransactionLine.Transaction)
                                       .Include(TransactionLine => TransactionLine.Item)
                                       .ToList();
        }

        public TransactionLine? GetById(int id)
        {
            using var context = new FuelGasStationDbContext();
            return context.TransactionsLine.Where(TransactionLine => TransactionLine.Id == id)
                                        .Include(TransactionLine => TransactionLine.Transaction)
                                        .Include(TransactionLine => TransactionLine.Item)
                                        .SingleOrDefault();
        }

        public void Update(int id, TransactionLine entity)
        {
            using var ctx = new FuelGasStationDbContext();
            var dbTransactionLine = ctx.TransactionsLine.Where(TransactionLine => TransactionLine.Id == id)
                                        .Include(TransactionLine => TransactionLine.Transaction)
                                        .Include(TransactionLine => TransactionLine.Item)
                                        .SingleOrDefault();
            if(dbTransactionLine is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            else
            {
                dbTransactionLine.Quantity= entity.Quantity;
                dbTransactionLine.ItemPrice= entity.ItemPrice;
                dbTransactionLine.NetValue= entity.NetValue;
                dbTransactionLine.PercentDiscount= entity.PercentDiscount;
                dbTransactionLine.DiscountValue= entity.DiscountValue;
                dbTransactionLine.TotalValue= entity.TotalValue;
                dbTransactionLine.TransactionID= entity.TransactionID;
                dbTransactionLine.ItemID= entity.ItemID;
                ctx.SaveChanges();
            }
        }
    }
}
