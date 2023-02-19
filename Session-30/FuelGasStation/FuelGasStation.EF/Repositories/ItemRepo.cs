using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelGasStation.Model;
using FuelGasStation.Model.Enums;
using FuelGasStation.EF.Context;

namespace FuelGasStation.EF.Repositories
{
    public class ItemRepo : IEntityRepo<Item>
    {
        public void Add(Item entity)
        {
            using var context = new FuelGasStationDbContext();
            if(entity.Id != 0)
            {
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            }
            context.Items.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new FuelGasStationDbContext();
            var dbItem = context.Items.SingleOrDefault(Item => Item.Id == id);
            if(dbItem is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Items.Remove(dbItem);
            context.SaveChanges();
        }

        public IList<Item> GetAll()
        {
            using var db = new FuelGasStationDbContext();
            return db.Items.ToList();
        }

        public Item? GetById(int id)
        {
            using var ctx = new FuelGasStationDbContext();
            return ctx.Items.SingleOrDefault(Item => Item.Id == id);
        }

        public void Update(int id, Item entity)
        {
            using var ctx = new FuelGasStationDbContext();
            var dbItem = ctx.Items.SingleOrDefault(item => item.Id == id);
            if(dbItem is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbItem.Code = entity.Code;
            dbItem.Descriptioon= entity.Descriptioon;
            dbItem.ItemType =  entity.ItemType;
            dbItem.Cost = entity.Cost;
            dbItem.Price = entity.Price;
            ctx.SaveChanges();
        }
    }
}
