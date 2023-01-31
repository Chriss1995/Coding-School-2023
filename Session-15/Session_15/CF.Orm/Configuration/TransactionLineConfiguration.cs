using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeshopModel;

namespace CF.Orm.Configuration
{
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.ToTable("Transaction");
            builder.HasKey(TransactionLine => TransactionLine.ID);
            builder.Property(TransactionLine => TransactionLine.ID).ValueGeneratedOnAdd();
            builder.Property(TransactionLine => TransactionLine.Date).HasConversion<DateTime>();
            builder.Property(TransactionLine => TransactionLine.Description).HasMaxLength(500);
            builder.Property(TransactionLine => TransactionLine.Quantity).HasConversion<int>();
            builder.Property(TransactionLine => TransactionLine.Price).HasConversion<decimal>();
            builder.Property(TransactionLine=> TransactionLine.TotalCost).HasConversion<decimal>();
            builder.Property(TransactionLine=> TransactionLine.TotalPrice).HasConversion<decimal>();
        }   
    }
}