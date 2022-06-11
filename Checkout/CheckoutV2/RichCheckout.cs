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

            foreach (var item in items)
            {
                var product =  _products[item];
                totalCost += product.Price;
                totalWeight += product.Weight;
                categories.Add(product.Type);
            }

            // Different ways to do this. More efficently too. But this is simplest way I could do it that is understandable
            // We do loop through array 3 times
            var allB = items.Count(x => x == 'B');
            var bToDiscount = ((allB / 2)) * _products['B'].Price; // We don't cast as want int rounding down
            totalCost -= bToDiscount;

            var allD = items.Count(x => x == 'D');
            var dToDiscount = ((allD / 3)) * _products['D'].Price; // We don't cast as want int rounding down
            totalCost -= dToDiscount;


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
}
