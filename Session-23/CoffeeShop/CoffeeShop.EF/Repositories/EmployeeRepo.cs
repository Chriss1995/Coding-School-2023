using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Model;
using CoffeeShop.Model.Enums;
using CoffeeShop.EF.Context;

namespace CoffeeShop.EF.Repositories
{
    public class EmployeeRepo
    {
        public void Add(Employee employee)
        {
            using var context = new CoffeeShopDbContext();
            context.Add(employee);
            context.SaveChanges();
        }
        public void Delete(int id) 
        {
            using var context= new CoffeeShopDbContext();
            var dbEmployee = context.Products.Where(Employee => Employee.Id == id).SingleOrDefault();
            if (dbEmployee is null)
                return;
            context.Remove(dbEmployee);
            context.SaveChanges();
        }
        public List<Employee> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            return context.Employees.ToList();
        }
        public Employee? GetByID(int id)
        {
            using var context = new CoffeeShopDbContext();
            return context.Employees.Where(Employee => Employee.Id == id).SingleOrDefault();
        }
        public void Update(int id , Employee employee)
        {
            using var context = new CoffeeShopDbContext();
            var dbEmployee = context.Employees.Where(Employee => Employee.Id == id).SingleOrDefault();
            if (dbEmployee is null) return;
            dbEmployee.Name = employee.Name;
            dbEmployee.Surname = employee.Surname;
            dbEmployee.SalaryPerMonth = employee.SalaryPerMonth;
            dbEmployee.EmployeeType = employee.EmployeeType;
        }
    }
}
