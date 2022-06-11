using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CheckOut
{

    public class CheckoutV1
    {
        private Dictionary<char, int> _products = new Dictionary<char, int>
        {
            {'A', 50},
            {'B', 30},
            {'C', 20},
            {'D', 5}
        };

        public decimal Calc(string input)
        {
            var items = input.ToCharArray();
            var totalCost = 0m;

            foreach (var item in items)
            {
                totalCost += _products[item];
            }

            // Different ways to do this. More efficently too. But this is simplest way I could do it that is understandable
            // We do loop through array 3 times
            var allB = items.Count(x => x == 'B');
            var bToDiscount = ((allB / 2)) * _products['B']; // We don't cast as want int rounding down
            totalCost -= bToDiscount;

            var allD = items.Count(x => x == 'D');
            var dToDiscount = ((allD / 3)) * _products['D']; // We don't cast as want int rounding down
            totalCost -= dToDiscount;


            // I meant buy 10 or more items haha but looking at instructions you did it right :)
            if (items.Length > 10)
            {
                totalCost -= (totalCost / 100 * 10);
            }


            return totalCost;
        }

        //  Have only done discount B here
        public decimal MoreEfficentCalc(string input)
        {
            var totalCost = 0m;
            var items = input.ToCharArray();
            var itemsByProduct = items.GroupBy(x => x).Select(x => new ItemAndCount() { Item = x.Key, Count = x.Count()});
            foreach (var itemAndCount in itemsByProduct)
            {
                if (itemAndCount.Item == 'B')
                {
                    totalCost += _products[itemAndCount.Item] * (itemAndCount.Count / 2);
                }
                else
                {
                    totalCost += _products[itemAndCount.Item] * itemAndCount.Count;
                }
            }
            return totalCost;
        }

        // as linq might be tricky: Have only done discount B here
        public decimal MoreEfficentCalcForLoop(string input)
        {
            var totalCost = 0m;
            var basket = input.ToCharArray();
            Dictionary<char, int> countByProduct = new Dictionary<char, int>();
            foreach (var item in basket)
            {
                if (countByProduct.ContainsKey(item))
                {
                    countByProduct[item] += 1;
                }
                else
                {
                    countByProduct.Add(item, 1);
                }

            }

            foreach (var itemAndCount in countByProduct)
            {
                if (itemAndCount.Key == 'B')
                {
                    totalCost += _products[itemAndCount.Key] * (itemAndCount.Value / 2);
                }
                else
                {
                    totalCost += _products[itemAndCount.Key] * itemAndCount.Value;
                }

            }
            return totalCost;
        }

        class ItemAndCount
        {
            public char Item { get; set; }
            public int Count { get; set; }
        }
    }
}
