using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WorkingWithVisualStudio.Models;

namespace WorkingWithVisualStudio.Controllers
{
    public class HomeController : Controller
    {
        public IRepository Repository = SimpleRepository.SharedRepository;
        public IActionResult Index() => View(SimpleRepository.SharedRepository.Products.
                                                                                Where(p => p.Price < 50));
        [HttpGet]
        public IActionResult AddProduct() => View(new Product());

        [HttpPost]
        public IActionResult Addproduct(Product p)
        {
            Repository.AddProduct(p);
            return RedirectToAction("Index");
        }
    }
}
