using FuelGasStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelGasStation.EF.Context;
using FuelGasStation.Model.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

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
            var dbTransaction = ctx.Transactions.Where(Transaction => Transaction.Id == id)
                                                .Include(Transaction => Transaction.Customer)
                                                .Include(Transaction => Transaction.Employee)
                                                .SingleOrDefault();
            if(dbTransaction is null) 
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            ctx.Remove(dbTransaction);
            ctx.SaveChanges();
        }

        public IList<Transaction> GetAll()
        {
            using var context = new FuelGasStationDbContext();
            return context.Transactions.Where(Transaction=> Transaction.Id == 0)
                .Include(Transaction => Transaction.Customer)
                .Include(Transaction => Transaction.Employee).ToList();
        }

        public Transaction? GetById(int id)
        {
            using var context = new FuelGasStationDbContext();
            return context.Transactions.Where(Transaction => Transaction.Id == id)
                .Include(Transaction => Transaction.Customer)
                .Include(Transaction=> Transaction.Employee)
                .FirstOrDefault();
        }

        public void Update(int id, Transaction entity)
        {
            using var context = new FuelGasStationDbContext();
            var dbTrannsaction = context.Transactions.Where(Transaction => Transaction.Id == id)
                                .Include(Transaction => Transaction.Customer)
                                .Include(Transaction => Transaction.Employee)
                                .SingleOrDefault();
            if (dbTrannsaction is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in daatabase");
            }
            else
            {
                dbTrannsaction.DateTime= entity.DateTime;
                dbTrannsaction.PaymentMetod= entity.PaymentMetod;
                dbTrannsaction.TotalValue= entity.TotalValue;
                dbTrannsaction.CustomerID= entity.CustomerID;
                dbTrannsaction.EmployeeID= entity.EmployeeID;
                context.SaveChanges();
            }
        }
    }
}
