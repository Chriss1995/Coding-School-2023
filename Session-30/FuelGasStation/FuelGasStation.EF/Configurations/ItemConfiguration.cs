using FuelGasStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelGasStation.EF.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
           //Table Name
           builder.ToTable("Item");

            //Primary Key
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            //Properties
            builder.Property(t => t.Code).HasMaxLength(20).IsRequired();
            builder.Property(t => t.Descriptioon).HasMaxLength(150).IsRequired();
            builder.Property(t => t.ItemType).IsRequired();
            builder.Property(t => t.Cost).HasPrecision(9,2).IsRequired();
            builder.Property(t=> t.Price).HasPrecision(9,2).IsRequired();

            //Relations
        }
    }
}
