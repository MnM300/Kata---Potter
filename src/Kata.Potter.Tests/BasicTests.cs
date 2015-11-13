using NUnit.Framework;

namespace Kata.Potter.Tests
{
    [TestFixture]
    public class BasicTests
    {
    
        [Test]
        public void NoBookTest()
        {
            Assert.That(0, Is.EqualTo(Price.GetTotalCost(new int[]{})));

        }

        [Test]
        public void SingleBookTest()
        {
            Assert.That(8, Is.EqualTo(Price.GetTotalCost(new[]{0})));
            Assert.That(8, Is.EqualTo(Price.GetTotalCost(new[]{1})));
            Assert.That(8, Is.EqualTo(Price.GetTotalCost(new[]{2})));
            Assert.That(8, Is.EqualTo(Price.GetTotalCost(new[]{3})));
            Assert.That(8, Is.EqualTo(Price.GetTotalCost(new[]{4})));
        }
        
        [Test]
        public void MultiBookTest()
        {
            Assert.That(8 * 2, Is.EqualTo(Price.GetTotalCost(new[]{0,0})));
            Assert.That(8 * 3, Is.EqualTo(Price.GetTotalCost(new[]{1,1,1})));
        }
    }
}
