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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(Product => Product.ID);
            builder.Property(Product => Product.ID).ValueGeneratedOnAdd();
            builder.Property(Product => Product.Code).HasConversion<int>();
            builder.Property(Product => Product.Description).HasMaxLength(500);
            builder.Property(Produt => Produt.TypeofProduct).HasConversion<string>();
            builder.Property(Product => Product.Price).HasConversion<decimal>();
            builder.Property(Product => Product.Cost).HasConversion<decimal>();
         

        }
    }
}