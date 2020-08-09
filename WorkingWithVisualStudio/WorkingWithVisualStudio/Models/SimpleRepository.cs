using System.Collections.Generic;

namespace WorkingWithVisualStudio.Models
{
    public class SimpleRepository : IRepository
    {
        public SimpleRepository()
        {
            var initialItems = new[]
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product{Name = "Lifejacket", Price = 48.95M},
                new Product{Name = "Soccer Ball", Price = 19.50M},
                new Product{Name = "Corner Flag", Price = 34.95M}
            };

            foreach (var item in initialItems)
            {
                AddProduct(item);
            }
        }

        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> products = new Dictionary<string, Product>();

        public static SimpleRepository SharedRepository => sharedRepository;

        public IEnumerable<Product> Products => products.Values;
        public void AddProduct(Product item) => products.Add(item.Name, item);

    }
}
