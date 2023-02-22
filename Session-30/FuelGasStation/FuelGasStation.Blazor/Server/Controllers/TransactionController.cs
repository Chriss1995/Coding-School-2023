using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FuelGasStation.Blazor.Shared.Transaction;
using FuelGasStation.Blazor.Shared.Customer;
using FuelGasStation.Blazor.Shared.Employee;
using FuelGasStation.Blazor.Shared.TransactionLine;
using FuelGasStation.EF.Repositories;
using FuelGasStation.Model;
using FuelGasStation.Model.Enums;
using Microsoft.Identity.Client;

namespace FuelGasStation.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<TransactionLine> _transLineRepo;

        public TransactionController(IEntityRepo<Transaction> transactionRepo,
                                      IEntityRepo<Customer> customerRepo,
                                      IEntityRepo<Employee> employeeRepo,
                                      IEntityRepo<TransactionLine> transLineRepo)
        {
            _transRepo = transactionRepo;
            _customerRepo = customerRepo;
            _employeeRepo = employeeRepo;
            _transLineRepo = transLineRepo;
        }

        [HttpGet]
        public IEnumerable<TransactionListDto> Get()
        {
            var result = _transRepo.GetAll();
            return result.Select(transaction => new TransactionListDto
            {
                Id = transaction.Id,
                DateTime = transaction.DateTime,
                PaymentMetod = transaction.PaymentMetod,
                TotalValue = transaction.TotalValue,
                CustomerID = transaction.CustomerID,
                CustomerSurname = transaction.Customer.Surname,
                EmployeeID = transaction.EmployeeID,
                EmployeeSurname = transaction.Employee.Surname
            });
        }

        [HttpGet("{id}")]
        public TransactionEditDto GetById(int id)
        {
            var result = _transRepo.GetById(id);
            var customers = _customerRepo.GetAll();
            var employees = _employeeRepo.GetAll();
            var TransactionLines = _transLineRepo.GetAll();
            return new TransactionEditDto
            {
                Id = id,
                DateTime = result.DateTime,
                PaymentMetod = result.PaymentMetod,
                TotalValue = result.TotalValue,
                Customers = customers.Select(customer => new CustomerListDto
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    Surname = customer.Surname,
                    CardNumber = customer.CardNumber
                }).ToList(),
                Employees = employees.Select(employees => new EmployeeListDto
                {
                    Id = employees.Id,
                    Name = employees.Name,
                    Surname = employees.Surname,
                    EmployeeType = employees.EmployeeType,
                    DateHireEnd = employees.DateHireEnd,
                    DateHireStart = employees.DateHireStart,
                    SalaryPerMonth = employees.SalaryPerMonth,
                }).ToList(),
                TransactionLines = result.TransactionLines.Select(trasLine => new TransactionLineListDto
                {
                    Id = trasLine.Id,
                    Quantity = trasLine.Quantity,
                    ItemPrice = trasLine.ItemPrice,
                    NetValue = trasLine.NetValue,
                    DiscountValue = trasLine.DiscountValue,
                    PercentDiscount = trasLine.PercentDiscount,
                    TotalValue = trasLine.TotalValue,
                    ItemID = trasLine.ItemID
                }).ToList()
            };
        }

        [HttpPost]
        public async Task Post(TransactionEditDto transaction)
        {
            var newTransaction = new Transaction(transaction.TotalValue, transaction.PaymentMetod)
            {
                Id = transaction.Id,
                DateTime = transaction.DateTime,
                CustomerID = transaction.CustomerID,
                EmployeeID = transaction.EmployeeID
            };

            _transRepo.Add(newTransaction);

            foreach (var line in transaction.TransactionLines)
            {
                var transactionline = new TransactionLine(line.Quantity, line.ItemPrice, line.NetValue, line.PercentDiscount, line.DiscountValue, line.TotalValue)
                {
                    Id = line.Id
                };
            }
        }
        [HttpPut]
        public async Task Put(TransactionEditDto transaction)
        {
            var itemToUpdate = _transRepo.GetById(transaction.Id);
            itemToUpdate.DateTime = itemToUpdate.DateTime;
            itemToUpdate.PaymentMetod = transaction.PaymentMetod;
            itemToUpdate.TotalValue = transaction.TotalValue;
            itemToUpdate.CustomerID = transaction.CustomerID;
            itemToUpdate.EmployeeID = transaction.EmployeeID;
            itemToUpdate.TransactionLines = transaction.TransactionLines.Select(transLine =>
                            new TransactionLine(transLine.Quantity, transLine.ItemPrice, transLine.NetValue, transLine.PercentDiscount, transLine.DiscountValue, transLine.TotalValue)
                            {
                                Id = transLine.Id
                            }).ToList();
            foreach (var line in transaction.TransactionLines)
            {
                var transactionline = new TransactionLine(line.Quantity, line.ItemPrice, line.NetValue, line.PercentDiscount, line.DiscountValue, line.TotalValue)
                {
                    Id = line.Id
                };
            }
            _transRepo.Update(transaction.Id, itemToUpdate);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _transRepo.Delete(id);
        }
    }
}
