using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
     //   bool FilterByPrice(Product P) => (P?.Price?? 0) >= 20;

        public ViewResult Index()
        {
            var products = new[] { new { Name = "Kayak", Price = 275M },
                                   new { Name = "Lifejacket", Price = 48.95M},
                                   new { Name = "Soccer Ball", Price = 19.50M},
                                   new { Name = "Corner Flag", Price = 34.95M} };

            return View(products.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));


            //      public async Task<ViewResult> 
            //      long? length = await MyAsyncMethods.GetPageLength();
            //
            //      return View(new string[] { $"Length:  {length}"});


            //      var products = new[] { new { Name = "Kayak", Price = 275M },
            //                             new { Name = "Lifejacket", Price = 48.95M},
            //                             new { Name = "Soccer Ball", Price = 19.50M},
            //                             new { Name = "Corner Flag", Price = 34.95M} };
            //      return View(products.Select(p=>p.GetType().Name));
            //
            //      return View(Product.GetProducts().Select(p => p?.Name));

            //    ShoppingCart cart = new ShoppingCart() { Products = Product.GetProducts() };
            //
            //    Product[] productArray = 
            //                       {
            //                        new Product {Name = "Kayak", Price = 275M},
            //                        new Product {Name = "Lifejacket", Price = 48.95M},
            //                        new Product {Name = "Soccer Ball", Price = 19.50M},
            //                        new Product {Name = "Corner Flag", Price = 34.95M}
            //                       };
            //    Func<Product, bool> nameFilter = delegate (Product prod)
            //    {
            //        return prod?.Name?[0] == 'S';
            //    };
            //    decimal priceFilterTotal = productArray.Filter(FilterByPrice).TotalPrices(); // productArray.Filter(p => (p?.Price ?? 0) >= 20).TotalPrices();
            //    decimal nameFilterTotal = productArray.Filter(nameFilter).TotalPrices(); // productArray.Filter(p => p.Name[0] == 'S').TotalPrices();
            //
            //
            //    return View("Index", new string[] {$"Price Filters: {priceFilterTotal:C2}", $"Name Total: {nameFilterTotal:C2}" });

            //   ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
            //   decimal cartTotal = cart.TotalPrices();
            //   return View("Index", new string[] { $"Total:  {cartTotal:C2} " });

            //     Dictionary<string, Product> products = new Dictionary<string, Product>
            //     {
            //         ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
            //         ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
            //     };
            //     return View("Index", products.Keys);

            //     List<string> results = new List<string>();
            //
            //     foreach (var item in Product.GetProducts())
            //     {
            //         string name = item?.Name ?? "<No Name>";
            //         decimal? price = item?.Price ?? 0;
            //         string relatedName = item?.Related?.Name ?? "<None>";
            //         results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
            //     }
            //
            //     return View(results);
        }
    }
}
