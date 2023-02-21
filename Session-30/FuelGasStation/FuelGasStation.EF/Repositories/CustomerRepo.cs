using FuelGasStation.EF.Context;
using FuelGasStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FuelGasStation.EF.Repositories
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        public void Add(Customer entity)
        {
            using var context = new FuelGasStationDbContext();
            if(entity.Id != 0)
            {
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            }
            context.Customers.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var ctx = new FuelGasStationDbContext();
            var dbCustomer = ctx.Customers.SingleOrDefault(Customer => Customer.Id == id);
            if (dbCustomer is null)
            {
                throw new KeyNotFoundException(nameof(dbCustomer));
            }
            ctx.Customers.Remove(dbCustomer);
            ctx.SaveChanges();
        }

        public IList<Customer> GetAll()
        {
            using var context = new FuelGasStationDbContext();
            return context.Customers.ToList();
        }

        public Customer? GetById(int id)
        {
            using var context = new FuelGasStationDbContext();
            return context.Customers.SingleOrDefault(Customer =>Customer.Id == id);
        }

        public void Update(int id, Customer entity)
        {
            using var context = new FuelGasStationDbContext();
            var dbCustomer = context.Customers.SingleOrDefault(Customer => Customer.Id == id);
            if(dbCustomer is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbCustomer.Name = entity.Name;
            dbCustomer.Surname = entity.Surname;
            dbCustomer.CardNumber = entity.CardNumber;
            context.SaveChanges();
        }
    }
}
