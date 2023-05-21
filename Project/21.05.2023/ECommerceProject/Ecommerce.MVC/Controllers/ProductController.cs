using Ecommerce.BLL.AbstractService;
using ECommerce.DAL.Context;
using Ecommerce.BLL.Service;
using ECommerce.Entity.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {

            return View(_productService.GetAllProducts());
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productService.CreateProduct(product);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var deleted = _productService.FindProduct(id);
            _productService.DeleteProduct(deleted);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var updated = _productService.GetAllProducts().Where(x=>x.Id == id).FirstOrDefault();
            return View(updated);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            _productService.UpdateProduct(product);
            return RedirectToAction("Index");
        }
    }
}
