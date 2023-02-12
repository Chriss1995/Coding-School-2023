using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Model;
using Session_23.Models.Employee;
using CoffeeShop.Model.Enums;
using CoffeeShop.EF.Repositories;

namespace Session_23.Controllers
{
    public class TransactionLineController : Controller
    {
        private readonly TransactionLineRepo _transactionLineRepo;
        private readonly TransactionRepo _transactionRepo;
        private readonly ProductRepo _productRepo;
        public TransactionLineController(TransactionLineRepo transactionLineRepo, TransactionRepo transactionRepo, ProductRepo productRepo)
        {
            _transactionLineRepo = transactionLineRepo;
            _transactionRepo = transactionRepo;
            _productRepo = productRepo;
        }

        // GET: TransactionLineController
        public ActionResult Index()
        {
           var TransactionLine = _transactionLineRepo.GetAll();
            return View(model: TransactionLine);
        }

        // GET: TransactionLineController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TransactionLineController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransactionLineController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: TransactionLineController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TransactionLineController/Edit/5
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

        // GET: TransactionLineController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TransactionLineController/Delete/5
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
