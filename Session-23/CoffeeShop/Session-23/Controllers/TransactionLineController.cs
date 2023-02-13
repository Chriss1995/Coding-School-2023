using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Model;
using CoffeeShop.Model.Enums;
using CoffeeShop.EF.Repositories;
using Session_23.Models.TransactionLine;
using Session_23.Models.Product;

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
            var newTransactionLine = new TransactionLineCreateDto();
            var products = _productRepo.GetAll();
            foreach (var Product in products)
            {
                newTransactionLine.Prpoduct.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(Product.Id.ToString(),Product.Id.ToString()));
            }
            return View(model: newTransactionLine);
        }

        // POST: TransactionLineController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionLineCreateDto transactionLine)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbTransactionLine = new TransactionLine(transactionLine.Quantity, transactionLine.Discount, transactionLine.Discount, transactionLine.TotalPrice)
            {
                ProductId = transactionLine.ProdctId
            };
            _transactionLineRepo.Add(dbTransactionLine);
            return RedirectToAction("Index");
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
