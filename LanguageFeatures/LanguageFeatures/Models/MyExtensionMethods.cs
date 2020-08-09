using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> products)
        {
            decimal total = 0;
            foreach (var item in products)
            {
                total += item?.Price ?? 0;
            }
            return total;
        }

        public static IEnumerable<Product> FilterByPrice(this IEnumerable<Product> productEnum, decimal minimumPrice)
        {
            foreach (var item in productEnum)
            {
                if ((item?.Price ?? 0) >= minimumPrice)
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<Product> FilterByName(this IEnumerable<Product> productEnum, char firstLetter)
        {
            foreach (var item in productEnum)
            {
                if (item?.Name?[0] == firstLetter)
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<Product> Filter(this IEnumerable<Product> productEnum, Func<Product, bool> selector)
        {
            foreach (var item in productEnum)
            {
                if (selector(item))
                {
                    yield return item;
                }
            }
        }
    }
}
