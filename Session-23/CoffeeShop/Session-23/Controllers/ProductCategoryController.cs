using Microsoft.AspNetCore.Http;
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
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var productCategories = _productCategoryRepo.GetByID(id.Value);
            if(productCategories == null)
            {
                return NotFound();
            }
            var viewProductCategpry = new ProductCategoryDetailsDto
            {
                Id= productCategories.Id,
                Code = productCategories.Code,
                ProductType= productCategories.ProductType,
                Description= productCategories.Description
            };
            return View(model: viewProductCategpry);
        }

        // GET: ProductCategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductCategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductCategoryCreateDto productCategories)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbProductCategory = new ProductCategory(productCategories.Code, productCategories.Description, productCategories.ProductType);
            _productCategoryRepo.Add(dbProductCategory);
            return RedirectToAction("Index");
        }

        // GET: ProductCategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbProductCatery = _productCategoryRepo.GetByID(id);
            if(dbProductCatery == null)
            {
               return NotFound();
            }
            var viewProductCategory = new ProductCategoryEditDto
            {
                Code = dbProductCatery.Code,
                Description = dbProductCatery.Description,
                ProductType= dbProductCatery.ProductType
            };
            return View(model: viewProductCategory);
        }

        // POST: ProductCategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,ProductCategoryEditDto productCategories)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbProductCategory = _productCategoryRepo.GetByID(id);
            if (dbProductCategory == null)
            {
                return NotFound();
            }
            dbProductCategory.Code = productCategories.Code;
            dbProductCategory.Description = productCategories.Description;
            dbProductCategory.ProductType = productCategories.ProductType;
            _productCategoryRepo.Update(id, dbProductCategory);
            return RedirectToAction(nameof(Index));
        }

        // GET: ProductCategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbProductCategory = _productCategoryRepo.GetByID(id);
            if(dbProductCategory == null) 
            { 
                return NotFound();
            }
            var viewProductCategory = new ProductCategoryDeleteDto
            {
                Code = dbProductCategory.Code,
                Description = dbProductCategory.Description,
                ProductType = dbProductCategory.ProductType
            };
            return View(model: viewProductCategory);
        }

        // POST: ProductCategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ProductCategoryDeleteDto productCategories)
        {
            _productCategoryRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
