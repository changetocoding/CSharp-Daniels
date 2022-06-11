using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckoutV2
{
    public class RichCheckout
    {
        public BasketResult Calc(string input)
        {
            var _products = Product.GetAllProducts().ToDictionary(x => x.Name);
            var items = input.ToCharArray();
            var totalCost = 0m;
            var totalWeight = 0d;
            List<string> categories = new List<string>();

            var itemsByProduct = items.GroupBy(x => x).Select(x => new ItemAndCount() { Item = x.Key, Count = x.Count() });
            foreach (var itemAndCount in itemsByProduct)
            {
                var product = _products[itemAndCount.Item];
                totalWeight += product.Weight * itemAndCount.Count;
                totalCost += _products[itemAndCount.Item].Price * itemAndCount.Count;
                categories.Add(product.Type);

                if (itemAndCount.Item == 'B')
                { 
                    // discount
                    totalCost -= _products[itemAndCount.Item].Price * (itemAndCount.Count / 2);
                }
                if (itemAndCount.Item == 'D')
                {
                    // discount
                    totalCost -= _products[itemAndCount.Item].Price * (itemAndCount.Count / 3);
                }
            }


            // I meant buy 10 or more items haha but looking at instructions you did it right :)
            if (items.Length > 10)
            {
                totalCost -= (totalCost / 100 * 10);
            }


            return new BasketResult()
            {
                Total = totalCost,
                Weight = totalWeight,
                Categories = string.Join(", ", categories.OrderBy(x => x).Distinct())
            };
        }

    }

    public class BasketResult
    {
        public decimal Total { get; set; }
        public double Weight { get; set; }
        public string Categories { get; set; }
    }


    class ItemAndCount
    {
        public char Item { get; set; }
        public int Count { get; set; }
    }
}
