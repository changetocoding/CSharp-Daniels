using CheckOut;
using NUnit.Framework;

namespace CheckTests
{
    public class CheckoutTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ThreeAs()
        {
            var checkout = new CheckoutV1();
            var result = checkout.Calc("AAA");


            Assert.That(result, Is.EqualTo(150));
        }

        [Test]
        public void RandomBasket()
        {
            var checkout = new CheckoutV1();
            var result = checkout.Calc("AABCD");
            
            Assert.That(result, Is.EqualTo(155));
        }

        [Test]
        public void ElevenItemsDiscount()
        {
            var checkout = new CheckoutV1();
            var result = checkout.Calc("AAAAAAAAAAA");

            Assert.That(result, Is.EqualTo(550 - 55));
        }

        [Test]
        public void TwoBsDiscount()
        {
            var checkout = new CheckoutV1();
            var result = checkout.Calc("BB");

            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void ThreeBs_OnlyOneIsDiscounted()
        {
            var checkout = new CheckoutV1();
            var result = checkout.Calc("BBB");

            Assert.That(result, Is.EqualTo(60));
        }

        [Test]
        public void ElevenBs_GetsBuyOneFreeAnd10PercDiscount()
        {
            var checkout = new CheckoutV1();
            var result = checkout.Calc("BBBBBBBBBBB");

            Assert.That(result, Is.EqualTo((30m * 6m)*0.9m ));
        }

        [Test]
        public void ThreeDs_OnlyOneIsDiscounted()
        {
            var checkout = new CheckoutV1();
            var result = checkout.Calc("DDD");

            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void FiveDs_OnlyOneIsDiscounted()
        {
            var checkout = new CheckoutV1();
            var result = checkout.Calc("DDDDD");

            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void MoreEfficent_RandomBasket()
        {
            var checkout = new CheckoutV1();
            var result = checkout.MoreEfficentCalcForLoop("AABCD");

            Assert.That(result, Is.EqualTo(155));
        }

        [Test]
        public void MoreEfficent_ThreeBs_OnlyOneIsDiscounted()
        {
            var checkout = new CheckoutV1();
            var result = checkout.Calc("BBB");

            Assert.That(result, Is.EqualTo(60));
        }
    }
}