```Checkout.cs
public class Checkout
    {
        private Dictionary<char, int> _products = new Dictionary<char, int>
        {
            {'A', 50},
            {'B', 30},
            {'C', 20},
            {'D', 5}
        };

        public decimal Calc(string itemsStr)
        {
            var items = itemsStr.ToCharArray();
            var total = 0m;

            foreach (var item in items)
            {
               var cost =  _products[item];
               total += cost;
            }

            return total;
        }
    }
```


```Test.cs
using System;
using System.Collections.Generic;
using ConsoleApp47;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }


        [Test]
        public void CheckoutCanCalcThreeAs()
        {
            // Setup
            var checkout = new Checkout();

            // Act
            var res = checkout.Calc("AAA");

            // Assert - check
            Assert.That(res, Is.EqualTo(150));
            Assert.AreEqual(150, res);
        }

        [Test]
        public void CheckoutCanCalcMixedBag()
        {
            // setup
            var basket = "ABCD";
            var checkout = new Checkout();

            // Act
            var res = checkout.Calc(basket);

            // Assert
            Assert.That(res, Is.EqualTo(50 + 30 + 20 + 5));
        }

        [Test]
        public void IfProductDoesNotExist()
        {
            // setup
            var basket = "E";
            var checkout = new Checkout();

            // Act & Assert
            Assert.Throws<KeyNotFoundException>(() => checkout.Calc(basket));
        }

        [Test]
        public void If11Items_ThenDiscount()
        {
            // setup
            var checkout = new Checkout();
            var basket = "AAAAAAAAAAA";

            // Act - Execute Test
            var res = checkout.Calc(basket);

            // Assert - checking it behaved the way you wanted
            Assert.That(res, Is.EqualTo(50 * 11 * 0.9));
        }
    }
}
```

# HW
Follow these tutorials to learn Nunit. Commit your code to github

- http://dotnetpattern.com/nunit-testfixture-example-usage
- https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit
- https://www.webtrainingroom.com/csharp/unit-testing
- https://testautomationu.applitools.com/nunit-tutorial/chapter4.2.html
