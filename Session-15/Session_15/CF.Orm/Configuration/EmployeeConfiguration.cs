using CoffeeshopModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Orm.Configuration
{
    public class EmployeeConfiguration: IEntityTypeConfiguration<Employee>
    { public void Configure(EntityTypeBuilder<Employee> builder) {
            builder.ToTable("Employee");
            builder.HasKey(Employee => Employee.ID);
            builder.Property(Employee => Employee.ID).ValueGeneratedOnAdd();
            builder.Property(Employee => Employee.Name).HasMaxLength(50);
            builder.Property(Employee => Employee.Surname).HasMaxLength(50);
            builder.Property(Employee=> Employee.TypeofEmployee).HasConversion<string>();
            builder.Property(Employee => Employee.SalaryPerMonth).HasConversion<decimal>();
                }
    }
}
