﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using Session_23.Models.ProductCategory;
using CoffeeShop.Model.Enums;


namespace Session_23.Controllers
{
    public class ProductCategoryController : Controller
    {
        // GET: ProductCategoryController
        private readonly ProductCategoryRepo _productCategoryRepo;
        public ProductCategoryController(ProductCategoryRepo productCategoryRepo)
        {
            _productCategoryRepo = productCategoryRepo;
        }
        public ActionResult Index()
        {
            var productCategories = _productCategoryRepo.GetAll();
            var ProductCategoryList = productCategories.ToList();
            return View(model: ProductCategoryList);
        }

        // GET: ProductCategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductCategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductCategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductCategoryCreateDto productCategory)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbProductCategory = new ProductCategory(productCategory.Code, productCategory.Description, productCategory.ProductType);
            _productCategoryRepo.Add(dbProductCategory);
            return RedirectToAction("Index");
        }

        // GET: ProductCategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductCategoryController/Edit/5
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

        // GET: ProductCategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductCategoryController/Delete/5
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
