using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationProduct.Models;

namespace WebApplicationProduct.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product("Подкустовный выползун", 152, "смотри фильм О чем говорят мужчины", "/images/img1.png") ;
            ViewBag.Product = product;

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Product(string ProductName, decimal Cost, string Desc, string PathImage)
        {
            /*передаем во вьюшку данные любым из 3 способов
                ViewBag.ProductName = ProductName;
                ViewData["ProductName"] = ProductName;
                TempData["ProductName"] = ProductName;
            */

            /*ViewBag.ProductName = ProductName;
            ViewBag.Cost = Cost;

            еще один способ
            */

            Product product = new Product(ProductName, Cost, Desc, PathImage);
            ViewBag.Product = product;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
