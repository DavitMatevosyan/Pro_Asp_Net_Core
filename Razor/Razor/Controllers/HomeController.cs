using Microsoft.AspNetCore.Mvc;
using Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product[] array =
            {
                new Product {Name = "Kayak", Price = 275M },
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer Ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 94.95M}
            };

            return View(array);
        }

    //    public ViewResult Index()
    //    {
    //        Product myProduct = new Product() { ProductId = 1, Name = "Kayak", Description = "A Boat for one person", Category = "Watersports", Price = 275M };
    //        ViewBag.StockLevel = 2;
    //
    //        return View(myProduct);
    //    }
    }
}
