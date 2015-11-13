using NUnit.Framework;

namespace Kata.Potter.Tests
{
    [TestFixture]
    public class SeveralDiscountsTest
    {
        [Test]
        public void TwoOneSetDiscountTest()
        {
            Assert.That( 8 + (8 * 2 * 0.95), Is.EqualTo(Price.GetTotalDiscountCost(new[] { 0, 0, 1 })));
        }

        [Test]
        public void TwoTwoSetDiscountTest()
        {
            Assert.That(2 * (8 * 2 * 0.95), Is.EqualTo(Price.GetTotalDiscountCost(new[] { 0, 0, 1, 1 })));
        }

        [Test]
        public void FourTwoSetDiscountTest()
        {
            Assert.That((8 * 4 * 0.8) + (8 * 2 * 0.95), Is.EqualTo(Price.GetTotalDiscountCost(new[] { 0, 0, 1, 2, 2, 3 })));
        }

        [Test]
        public void FiveOneSetDiscountTest()
        {
            Assert.That(8 + (8 * 5 * 0.75), Is.EqualTo(Price.GetTotalDiscountCost(new[] { 0, 1, 1, 2, 3, 4 })));
        }
    }
}
