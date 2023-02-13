﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_23.Models.Transanction;
using CoffeeShop.Model.Enums;
using CoffeeShop.EF.Repositories;
using Session_23.Models.TransactionLine;
using CoffeeShop.Model;

namespace Session_23.Controllers
{ 
    public class TransactionController : Controller
    {
        private readonly TransactionLineRepo _transactionLineRepo;
        private readonly TransactionRepo _transactionRepo;
        private readonly EmployeeRepo _employeeRepo;
        private readonly CustomerRepo _customerRepo;
        public TransactionController(TransactionLineRepo transactionLineRepo, TransactionRepo transactionRepo, EmployeeRepo employee, CustomerRepo customer)
        {
            _transactionLineRepo = transactionLineRepo;
            _transactionRepo = transactionRepo;
            _employeeRepo= employee;
            _customerRepo = customer;
        }       
        // GET: TransactionController
        public ActionResult Index()
        {
            var Transaction = _transactionRepo.GetAll();
            return View(model: Transaction);
        }

        // GET: TransactionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TransactionController/Create
        public ActionResult Create()
        {
            var newTransaction = new TransactionCreateDto();
            var customers=_customerRepo.GetAll();
            foreach (var Customer in customers)
            {
                newTransaction.Customer.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(Customer.Id.ToString(), Customer.Id.ToString()));
            }
            var employees = _employeeRepo.GetAll();
            foreach (var Employee in employees)
            {
                newTransaction.Employee.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(Employee.Id.ToString(), Employee.Id.ToString()));
            }
            return View(model: newTransaction);
        }

        // POST: TransactionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionCreateDto transaction)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var dbTransaction = new Transaction(transaction.TotalPrice, transaction.PaymentMethod)
            {
                EmployeeId = transaction.EmployeeId,
                CustomerId = transaction.CustomerId
            };
            _transactionRepo.Add(dbTransaction);
            return RedirectToAction("Index");
        }

        // GET: TransactionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TransactionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TransactionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TransactionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
