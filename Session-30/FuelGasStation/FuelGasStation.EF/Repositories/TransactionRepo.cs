using FuelGasStation.EF.Context;
using FuelGasStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelGasStation.Model.Enums;
using Microsoft.EntityFrameworkCore;

namespace FuelGasStation.EF.Repositories
{
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        public void Add(Transaction entity)
        {
            using var context = new FuelGasStationDbContext();
            if (entity.Id != 0)
            {
                throw new ArgumentException("Given entity would not have Id set", nameof(entity));
            }
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
          using var ctx = new FuelGasStationDbContext();
            var dbTransanction = ctx.Transactions.Where(Transaction => Transaction.Id == id)
                                     .Include(Transaction => Transaction.Customer)
                                     .Include(Transaction => Transaction.Employee).SingleOrDefault();
            if (dbTransanction is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            else
            {
                ctx.Remove(dbTransanction);
                ctx.SaveChanges();
            }
        }

        public IList<Transaction> GetAll()
        {
            using var context =new FuelGasStationDbContext();
            return context.Transactions.Include(Transaction => Transaction.Customer)
                                     .Include(Transaction => Transaction.Employee).ToList();
        }

        public Transaction? GetById(int id)
        {
            using var context = new FuelGasStationDbContext();
            return context.Transactions.Where(Transaction => Transaction.Id == id)
                                     .Include(Transaction => Transaction.Customer)
                                     .Include(Transaction => Transaction.Employee).SingleOrDefault();
        }

        public void Update(int id, Transaction entity)
        {
            using var context = new FuelGasStationDbContext();
            var dbTransanction = context.Transactions.Where(Transaction => Transaction.Id == id)
                                    .Include(Transaction => Transaction.Customer)
                                    .Include(Transaction => Transaction.Employee).SingleOrDefault();
            if (dbTransanction is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            else
            {
                dbTransanction.DateTime= entity.DateTime;
                dbTransanction.PaymentMetod= entity.PaymentMetod;
                dbTransanction.TotalValue= entity.TotalValue;
                dbTransanction.CustomerID = entity.CustomerID;
                dbTransanction.EmployeeID = entity.EmployeeID;
                context.SaveChanges();
            }
        }
    }
}
