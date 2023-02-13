using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using Session_23.Models.Product;

namespace Session_23.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepo _productRepo;
        private readonly ProductCategoryRepo _productCategoryRepo;
        public ProductController(ProductRepo productRepo, ProductCategoryRepo productCategoryRepo)
        {
            _productRepo = productRepo;
            _productCategoryRepo = productCategoryRepo;
        }

        // GET: ProductController
        public ActionResult Index()
        {
           var products = _productRepo.GetAll();
           var productsList = products.ToList();
           return View(model: productsList); 
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var product = _productRepo.GetByID(id.Value);
            if(product == null)
            {
                return NotFound();
            }
            var viewProduct = new ProductDetailsDto
            {
                Code = product.Code,
                Description = product.Description,
                Price = product.Price,
                Cost =product.Cost,
                ProductCategoryId = product.ProductCategoryId
            };
            return View(model: viewProduct);

        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            var newProduct = new ProductCreateDto();
            var productCategories = _productCategoryRepo.GetAll();
            foreach(var ProductCategory in productCategories)
            {
                newProduct.ProductCategory.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(ProductCategory.Id.ToString(), ProductCategory.Id.ToString()));
            }
            return View(model: newProduct);
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int id, ProductCreateDto product)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbProduct = new Product(product.Code, product.Description, product.Price, product.Cost)
            {
                ProductCategoryId = product.ProductCategoryId
            };
            _productRepo.Add(dbProduct);
            return RedirectToAction("Index");
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbProduct = _productRepo.GetByID(id);
            if(dbProduct == null)
            {
                return NotFound();
            }
            var ProductDto = new ProductEditDto()
            {
                Code = dbProduct.Code,
                Description= dbProduct.Description,
                Price= dbProduct.Price,
                Cost= dbProduct.Cost
            };
            var ProductCategories = _productCategoryRepo.GetAll();
            foreach(var ProductCategory in ProductCategories)
            {
                ProductDto.ProductCategory.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(ProductCategory.Id.ToString(), ProductCategory.Id.ToString()));
            }
            return View(ProductDto);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductEditDto product)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return View();
                }
                var dbProduct = _productRepo.GetByID(id);
                if(dbProduct == null)
                {
                    return NotFound();
                }
                dbProduct.Code = product.Code;
                dbProduct.Description = product.Description;
                dbProduct.Price = product.Price;
                dbProduct.Cost = product.Cost;
                dbProduct.ProductCategoryId = product.ProductCategoryId;
                _productRepo.Update(id, dbProduct);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbProduct = _productRepo.GetByID(id);
            if(dbProduct == null)
            {
                return NotFound();
            }
            var viewProduct = new ProductDeleteDto()
            {
                Code = dbProduct.Code,
                Description = dbProduct.Description,
                Price = dbProduct.Price,
                Cost = dbProduct.Cost,
                ProductCategoryId = dbProduct.ProductCategoryId
            };
            return View(model: viewProduct);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ProductDeleteDto product)
        {
            _productRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
