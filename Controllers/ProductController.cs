using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OrnekUygulamaMVC.Models;

namespace OrnekUygulamaMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            var products = new List<Product>
            {
                new Product{Id=1,ProductName = "A Product",Quantity = 10},
                new Product{Id=1,ProductName = "B Product",Quantity = 15},
                new Product{Id=1,ProductName = "C Product",Quantity = 20}
            };

            return View(products);
        }

        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(object x)
        {
            return View();
        }
    }
}
