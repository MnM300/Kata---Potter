using NUnit.Framework;

namespace Kata.Potter.Tests
{
    [TestFixture]
    class SimpleDiscounts
    {
        [Test]
        public void TwoItemDiscountTest()
        {
            Assert.That(8 * 2 * 0.95, Is.EqualTo(Price.GetTotalDiscountCost(new[]{0,0})));
        }

        [Test]
        public void ThreeItemDiscountTest()
        {
            Assert.That(8 * 3 * 0.9, Is.EqualTo(Price.GetTotalDiscountCost(new[] { 0, 2, 4 })));
        }

        [Test]
        public void FourItemDiscountTest()
        {
            Assert.That(8 * 4 * 0.8, Is.EqualTo(Price.GetTotalDiscountCost(new[] { 0, 1, 2, 4 })));
        }

        [Test]
        public void FiveItemDiscountTest()
        {
            Assert.That(8 * 5 * 0.75, Is.EqualTo(Price.GetTotalDiscountCost(new[] { 0, 1, 2, 3, 4 })));
        }
    }
}
