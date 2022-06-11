using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutV2
{
    public class Product
    {
        public string Type { get; set; }
        public decimal Price { get; set; }
        public double Weight { get; set; }
        public char Name { get; set; }

        public static List<Product> GetAllProducts()
        {
            return new List<Product>()
            {
                new Product(){ Name = 'A', Price = 50, Weight = 2, Type = "Electronics"},

                new Product(){ Name = 'B', Price = 30, Weight =  20,Type = "Household Goods"},
                new Product(){ Name = 'C', Price = 20, Weight =  10,Type = "Groceries"},
                new Product(){ Name = 'D', Price = 5, Weight = 1,   Type = "Groceries"},
                new Product(){ Name = 'E', Price = 8, Weight = 1.2, Type = "Groceries"},
                new Product(){ Name = 'F', Price = 25, Weight =  1, Type = "Alcohol"},
            };
        }
    }
}
