using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Model;
using Session_23.Models.Customer;
using CoffeeShop.EF.Repositories;

namespace Session_23.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerRepo _customerRepo;
        public CustomerController(CustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
           var customers = _customerRepo.GetAll();
            var CustomerList = customers.ToList();
            return View(model : CustomerList);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var customer = _customerRepo.GetByID(id.Value);
            if(customer == null)
            {
                return NotFound();
            }
            var viewCustomer = new CustomerDetailsDto
            {
                Code = customer.Code,
                Description = customer.Description,
            };
            return View(model: viewCustomer);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerCreateDto customer)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbCustomer = new Customer(customer.Code, customer.Description);
            _customerRepo.Add(dbCustomer);
            return RedirectToAction("Index");
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
          var dbCustomer = _customerRepo.GetByID(id);
          if(dbCustomer == null)
            {
                return NotFound();
            }
            var viewCustomer = new CustomerEditDto
            {
                Code = dbCustomer.Code,
                Description = dbCustomer.Description,
            };
            return View(model: viewCustomer);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CustomerEditDto customer)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbCustomer = _customerRepo.GetByID(id);
            if(dbCustomer == null)
            {
                return NotFound();
            }
            dbCustomer.Description = dbCustomer.Description;
            dbCustomer.Code = dbCustomer.Code;
            _customerRepo.Update(id, dbCustomer);
            return RedirectToAction(nameof(Index));
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbCustomer = _customerRepo.GetByID(id);
            if(dbCustomer == null)
            {
                return NotFound();
            }
            var viewCustomer = new CustomerDeleteDto
            {
                Code = dbCustomer.Code,
                Description = dbCustomer.Description,
            };
            return View(model: viewCustomer);
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CustomerDeleteDto customer)
        {
            _customerRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
