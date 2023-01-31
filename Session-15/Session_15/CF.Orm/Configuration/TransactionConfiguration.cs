using CoffeeshopModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Orm.Configuration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");
            builder.HasKey(Transaction => Transaction.ID);
            builder.Property(Transaction => Transaction.ID).ValueGeneratedOnAdd();
            builder.Property(Transaction => Transaction.Date).HasConversion<DateTime>();
            builder.Property(Transaction => Transaction.Cost).HasConversion<decimal>();
            builder.Property(Transaction => Transaction.TotalPrice).HasConversion<decimal>();
        }
    }
}
