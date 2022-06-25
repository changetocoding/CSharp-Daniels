using System;
using System.Collections.Generic;
using System.Text;

namespace CheckOut
{
    public interface IDiscount
    { 
        bool CanDiscount(char product);

        decimal DiscountAmount(int count);
    }

    public class BogofDiscount : IDiscount
    {
        private readonly char _product;
        private readonly decimal _cost;
        private readonly int _discountAfter;

        public BogofDiscount(char product, decimal cost, int discountAfter)
        {
            _product = product;
            _cost = cost;
            _discountAfter = discountAfter;
        }
        public bool CanDiscount(char product)
        {
            return product == _product;
        }

        public decimal DiscountAmount(int count)
        {
            return _cost* (count / _discountAfter); // This is deliberate want to round down
        }
    }
}
