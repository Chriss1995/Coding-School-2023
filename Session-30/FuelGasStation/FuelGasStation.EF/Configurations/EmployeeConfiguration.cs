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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            //Table Name
            builder.ToTable("Employees");

            //Primary Key
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            //Properties
            builder.Property(t =>t.Name).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Surname).HasMaxLength(100).IsRequired();
            builder.Property(t => t.DateHireStart).IsRequired();
            builder.Property(t => t.DateHireEnd);
            builder.Property(t => t.SalaryPerMonth).IsRequired();
            builder.Property(t => t.EmployeeType).IsRequired();

            //Relations
        }
    }
}
