using NUnit.Framework;
using R_Workshop1;
using System.Collections.Generic;

namespace R_Workshop1Test
{
    public class CalculatorTest
    {
        [Test]
        public void ShouldSumTwoPositiveNumbers()
        {
            var calc = new Calculator();
            var result = calc.add(5, 6);
            Assert.That(result, Is.EqualTo(11));
            
            var expectedOperations = new List<string> { "Added 5 and 6 got result: 11" };
            CollectionAssert.AreEqual(expectedOperations, calc.Operations);
        }

    }
}
