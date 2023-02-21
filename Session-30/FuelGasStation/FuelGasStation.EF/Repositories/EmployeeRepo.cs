using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelGasStation.Model;
using FuelGasStation.EF.Context;
using System.Data;

namespace FuelGasStation.EF.Repositories
{
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        public void Add(Employee entity)
        {
            using var context = new FuelGasStationDbContext();
            if (entity.Id != 0)
            {
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            }
            context.Employees.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new FuelGasStationDbContext();
            var dbEmployee = context.Employees.SingleOrDefault(Employee => Employee.Id == id);
            if (dbEmployee is null) 
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Employees.Remove(dbEmployee);
            context.SaveChanges();
        }

        public IList<Employee> GetAll()
        {
            using var context = new FuelGasStationDbContext();
            return context.Employees.ToList();
        }

        public Employee? GetById(int id)
        {
            using var context = new FuelGasStationDbContext();
            return context.Employees.SingleOrDefault(Employee =>Employee.Id == id);
        }

        public void Update(int id, Employee entity)
        {
            using var context = new FuelGasStationDbContext();
            var dbEmployee = context.Employees.SingleOrDefault(Employee=>Employee.Id == id);
            if (dbEmployee is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbEmployee.Name= entity.Name;
            dbEmployee.Surname = entity.Surname;
            dbEmployee.DateHireStart= entity.DateHireStart;
            dbEmployee.DateHireEnd= entity.DateHireEnd;
            dbEmployee.SalaryPerMonth= entity.SalaryPerMonth;
            dbEmployee.EmployeeType= entity.EmployeeType;
            context.SaveChanges();
        }   
    }
}
