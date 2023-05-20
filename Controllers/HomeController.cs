using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace OrnekUygulamaMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var images = new List<string>() { "img1", "img2", "img3", "img4" };
            return View(images);
        }

        public IActionResult Sayfa1()
        {
            return View();
        }
        public IActionResult Sayfa2()
        {
            return View();
        }
    }
}
