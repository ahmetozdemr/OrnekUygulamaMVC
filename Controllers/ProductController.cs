using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OrnekUygulamaMVC.Models;
using OrnekUygulamaMVC.Models.ViewModels;

namespace OrnekUygulamaMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            //var products = new List<Product>
            //{
            //    new Product{ProductName = "A Product",Quantity = 10},
            //    new Product{ProductName = "B Product",Quantity = 15},
            //    new Product{ProductName = "C Product",Quantity = 20}
            //};
            //return View(products);
            Product product = new Product
            {
                ProductName = "A product",
                Quantity = 15
            };
            User user = new User
            {
                Id = 1,
                Name = "Ramazan",
                LastName = "Merkez"
            };
       var userProduct = (product,user);
            return View(userProduct);
        }

        public IActionResult CreateProduct()
        {
            var product = new Product();

            return View(product);
        }

        [HttpPost]
      //  public IActionResult CreateProduct(string txtProductName, int txtQuantity)
        public IActionResult CreateProduct(Product product)
        {
            return View();
        }
    }
}
