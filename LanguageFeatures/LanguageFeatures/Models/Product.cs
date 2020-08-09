using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public Product(bool stock = true)
        {
            InStock = stock;
        }

        public string Name { get; set; }
        public string Category { get; set; } = "Watersports";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; }
        public bool NameStartsWithS => Name?[0] == 'S';


        public static Product[] GetProducts()
        {
            Product Kayak = new Product { Name = "Kayak", Category = "Water Craft", Price = 275M };
            Product Lifejacket = new Product(false) { Name = "Lifejaket", Price = 48.95M };

            Kayak.Related = Lifejacket;

            return new Product[] { Kayak, Lifejacket, null };
        }
    }
}
