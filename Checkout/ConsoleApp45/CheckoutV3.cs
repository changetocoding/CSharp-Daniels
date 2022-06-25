using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CheckOut
{
    /// <summary>
    /// Applying the open closed principle for discount
    /// </summary>
    public class CheckoutV3
    {
        private readonly List<IDiscount> _discounts;

        public CheckoutV3(List<IDiscount> discounts)
        {
            _discounts = discounts;
        }

        public CheckoutV3()
        {
            _discounts = new List<IDiscount>()
            {
                new BogofDiscount('B', 30, 2),
                new BogofDiscount('D', 5, 3),
            };
        }
        
        private Dictionary<char, int> _products = new Dictionary<char, int>
        {
            {'A', 50},
            {'B', 30},
            {'C', 20},
            {'D', 5}
        };


        //  Have not done 10% discount
        public decimal Calc(string input)
        {
            var totalCost = 0m;
            var items = input.ToCharArray();
            var itemsByProduct = items.GroupBy(x => x).Select(x => new ItemAndCount() { Item = x.Key, Count = x.Count() });
            foreach (var itemAndCount in itemsByProduct)
            {
                totalCost += _products[itemAndCount.Item] * itemAndCount.Count;

                foreach (var discount in _discounts)
                {
                    if (discount.CanDiscount(itemAndCount.Item))
                    {
                        totalCost -= discount.DiscountAmount(itemAndCount.Count);
                    }
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
