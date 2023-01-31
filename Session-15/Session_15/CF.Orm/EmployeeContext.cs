using CoffeeshopModel;
using Microsoft.EntityFrameworkCore;

namespace CF.Orm
{
    public class EmployeeContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DataSource=(LocalDB)\\MSSQL(localDB); Initial Catalog=CoffeeShopDB; Integrated Security=True; Connect Timeout=30; Encrypt= False; TrustedServerCertificate= False; ApplicationIntent=ReadWrite;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}