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
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("Product Category");
            builder.HasKey(ProductCategory => ProductCategory.ID);
            builder.Property(ProductCategory => ProductCategory.ID).ValueGeneratedOnAdd();
            builder.Property(ProductCategory => ProductCategory.Code).HasConversion<int>();
            builder.Property(ProductCategory => ProductCategory.Description).HasMaxLength(500);


        }
    }
}
