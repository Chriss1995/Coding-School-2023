using CF.Orm.Configuration;
using CoffeeshopModel;
using Microsoft.EntityFrameworkCore;

namespace CF.Orm.Context
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionLine> transactionLines { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
          modelBuilder.ApplyConfiguration(new ProductConfiguration());
          modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
         modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionLineConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TodoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}