using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrnekUygulamaMVC.Models;
using OrnekUygulamaMVC.Models.ViewModels;

namespace OrnekUygulamaMVC.Controllers
{
    public class AjaxData
    {
        public string A { get; set; }
        public string B { get; set; }   
    }

    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            return View();
        }
        //public IActionResult CreateProduct(QuaryData quaryData)
        //{
        //    var queryString = Request.QueryString;
        //    var a = Request.Query["a"].ToString();
        //    var b = Request.Query["b"].ToString();

        //    return View();
        //}

        //[HttpPost]
        //public IActionResult CreateProduct(IFormCollection datas)
        //{
        //    var value1 = datas["txtvalue1"];
        //    var value2 = datas["txtvalue2"];
        //    var value3 = datas["txtvalue3"];

        //    return View();
        //}

        public IActionResult CreateProduct()
        {
            //var headers = Request.Headers.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(AjaxData data)
        {
            //var headers = Request.Headers.ToList();
     
            return View();
        }

    }
}
