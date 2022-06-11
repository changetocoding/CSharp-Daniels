using CheckOut;
using CheckoutV2;
using NUnit.Framework;

namespace CheckTests
{
    public class RichCheckoutTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ThreeAs()
        {
            var checkout = new RichCheckout();
            var result = checkout.Calc("AAA");


            Assert.That(result.Total, Is.EqualTo(150));
            Assert.That(result.Weight, Is.EqualTo(6));
            Assert.That(result.Categories, Is.EqualTo("Electronics"));
        }

        [Test]
        public void RandomBasket()
        {
            var checkout = new RichCheckout();
            var result = checkout.Calc("DEF");

            Assert.That(result.Total, Is.EqualTo(38));
            Assert.That(result.Weight, Is.EqualTo(3.2));
            Assert.That(result.Categories, Is.EqualTo("Alcohol, Groceries"));
        }

        [Test]
        public void ElevenItemsDiscount()
        {
            var checkout = new RichCheckout();
            var result = checkout.Calc("AAAAAAAAAAA");

            Assert.That(result.Total, Is.EqualTo(550 - 55));
        }

        [Test]
        public void TwoBsDiscount()
        {
            var checkout = new RichCheckout();
            var result = checkout.Calc("BB");

            Assert.That(result.Total, Is.EqualTo(30));
        }

        [Test]
        public void ThreeBs_OnlyOneIsDiscounted()
        {
            var checkout = new RichCheckout();
            var result = checkout.Calc("BBB");

            Assert.That(result.Total, Is.EqualTo(60));
            Assert.That(result.Weight, Is.EqualTo(60));
        }

        [Test]
        public void ThreeDs_OnlyOneIsDiscounted()
        {
            var checkout = new RichCheckout();
            var result = checkout.Calc("DDD");

            Assert.That(result.Total, Is.EqualTo(10));
        }
    }
}