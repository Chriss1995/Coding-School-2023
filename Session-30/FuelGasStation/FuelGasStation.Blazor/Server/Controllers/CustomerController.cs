using FuelGasStation.EF.Repositories;
using FuelGasStation.Model;
using FuelGasStation.Blazor.Shared.Customer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FuelGasStation.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        readonly IEntityRepo<Customer> _customerRepo;

        public CustomerController(IEntityRepo<Customer> customerRepo)
        {
            _customerRepo = customerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerListDto>> Get()
        {
            var result = _customerRepo.GetAll();
            return result.Select(Customer => new CustomerListDto
            {
                Id = Customer.Id,
                Name = Customer.Name,
                Surname = Customer.Surname,
                CardNumber = Customer.CardNumber,
            });
        }

        [HttpGet("{id}")]
        public async Task<CustomerEditDto> GetById(int id)
        {
            var result = _customerRepo.GetById(id);
            return new CustomerEditDto
            {
                Id = result.Id,
                Name = result.Name,
                Surname = result.Surname,
                CardNumber = result.CardNumber
            };
        }

        [HttpPost]
        public async Task Post(CustomerEditDto customer)
        {
            var newCustomer = new Customer(customer.Name, customer.Surname, customer.CardNumber);
            _customerRepo.Add(newCustomer);
        }

        [HttpPut]
        public async Task Put(CustomerEditDto customer)
        {
            var itemToUpdate = _customerRepo.GetById(customer.Id);
            itemToUpdate.Name = customer.Name;
            itemToUpdate.Surname = customer.Surname;
            itemToUpdate.CardNumber = customer.CardNumber;
            _customerRepo.Update(customer.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            _customerRepo.Delete(id);
            return Ok();
        }
    }
}
