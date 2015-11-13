using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kata.Potter.Tests
{
    [TestFixture]
    class EdgeCasesTest
    {
        [Test]
        public void FourFourDiscountTest()
        {
            Assert.That(2 * (8 * 4 * 0.8), Is.EqualTo(Price.Optimizeset(new[]
            {
                0, 0, 
                1, 1, 
                2, 2, 
                3, 4
            })));
        } 
        [Test]
        public void FiveThreeDiscountTest()
        {
            Assert.That(3 * (8 * 5 * 0.75) + 2 * (8 * 4 * 0.8), Is.EqualTo(Price.Optimizeset(new[]
            {
               0, 0, 0, 0, 0, 
               1, 1, 1, 1, 1, 
               2, 2, 2, 2, 
               3, 3, 3, 3, 3, 
               4, 4, 4, 4
            })));
        }
    }
}
