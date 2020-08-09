using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        /// <summary>
        /// In the Url of this page add ?productPage = <paramref name="productPage"/>
        /// </summary>
        /// <param name="productPage">the page that is wanted</param>
        /// <returns></returns>
        public ViewResult List(string category, int productPage = 1)
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                .Where(p => category == null || p.Category == category) // Select those items which have the same category as the given one
                .OrderBy(p => p.ProductId) // ordering by their Id
                .Skip((productPage - 1) * PageSize) // NOT Skipping PageSize amount of items
                .Take(PageSize),  // and taking them
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ? repository.Products.Count() :
                                                    repository.Products.Where(e => 
                                                    e.Category == category).Count()
                },
                CurrentCategory = category
            });
    } 
}