using FuelGasStation.EF.Repositories;
using FuelGasStation.Model;
using FuelGasStation.Blazor.Shared.MonthlyLedger;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace FuelGasStation.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MonthlyLedgerController : ControllerBase
    {
        private IEntityRepo<Transaction> _transRepo;
        private IEntityRepo<Employee> _employeeRepo;

        public MonthlyLedgerController(IEntityRepo<Transaction> transRepo, IEntityRepo<Employee> employeeRepo)
        {
            _transRepo = transRepo;
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<MonthlyLedgerDto>> Get()
        {
            List<MonthlyLedgerDto> monthlyLedgers = new();
            var transactions = _transRepo.GetAll().ToList();
            var employees = _employeeRepo.GetAll().ToList();

            var rent = 5000;
            decimal totalTransactions = 0;
            decimal totalSalaryEmployees = 0;
            
            foreach ( var transaction in transactions ) 
            {
                totalTransactions += transaction.TotalValue;
            }

            foreach(var employee in employees )
            {
                //totalSalaryEmployees += employees.Select(employee => employee.SalaryPerMonth)
                //.SingleOrDefault();
                totalSalaryEmployees += employee.SalaryPerMonth;
            }

            var groupedTransactions = transactions.GroupBy(transactions => new { transactions.DateTime.Year, transactions.DateTime.Month })
               .Select(grouped => new MonthlyLedgerDto
               {
                   Year = grouped.Key.Year,
                   Month = grouped.Key.Month,
                   Income = totalTransactions,
                   Expenses = totalSalaryEmployees + rent,
                   Total = totalTransactions - (totalSalaryEmployees + rent)
               });
            
            foreach(var grouped in groupedTransactions )
            {
                monthlyLedgers.Add( grouped );
            }
            
            return groupedTransactions;
        }
    }
}
