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

            var otherResult = calc.add(0.1, 0.2);
            Assert.That(otherResult, Is.EqualTo(0.3).Within(0.1));

            var expectedOperations = new List<string> { "Added 5 and 6 got result: 11", "Added 0,1 and 0,2 got result: 0,30000000000000004" };
            CollectionAssert.AreEqual(expectedOperations, calc.Operations);

            calc.clearOperations();
            CollectionAssert.IsEmpty(calc.Operations);
        }

    }
}
