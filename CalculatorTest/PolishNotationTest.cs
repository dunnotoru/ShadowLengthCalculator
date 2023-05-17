using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShadowLengthCalculator;
using System;

namespace CalculatorTest
{
    public class PolishNotationTest
    {
        [TestClass]
        public class CalculatorTestClass
        {
            [TestMethod]
            public void NumberAddition()
            {
                PolishNotationCalculator pol = new PolishNotationCalculator("2+2+2+2");
                double actual = pol.Calculate();
                double expected = 2 + 2 + 2 + 2;

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void NumberSubtraction()
            {
                PolishNotationCalculator pol = new PolishNotationCalculator("1000 - 7");
                double actual = pol.Calculate();
                double expected = 1000 - 7;

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void NumberMultiplication()
            {
                PolishNotationCalculator pol = new PolishNotationCalculator("12 * 35");
                double actual = pol.Calculate();
                double expected = 12 * 35;

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void NumberIntegerDivision()
            {
                PolishNotationCalculator pol = new PolishNotationCalculator("100 / 10");
                double actual = pol.Calculate();
                double expected = 100 / 10;

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void NumberDivision()
            {
                PolishNotationCalculator pol = new PolishNotationCalculator("4 / 20");
                double actual = pol.Calculate();
                double expected = 4.0 / 20;

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void InvalidCharactersTest()
            {
                Assert.ThrowsException<ArgumentException>(() => new PolishNotationCalculator("2+a+2*5"));
            }

            [TestMethod]
            public void BracketsTest()
            {
                PolishNotationCalculator pol = new PolishNotationCalculator("3 * (10 + 13)");
                double actual = pol.Calculate();
                double expected = 3 * (10 + 13);

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void OperationPriorityTest()
            {
                PolishNotationCalculator pol = new PolishNotationCalculator("28 - 2 * 2^7");
                double actual = pol.Calculate();
                double expected = 28 - 2 * Math.Pow(2, 7);

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void FractionalNumbersTest()
            {
                PolishNotationCalculator pol = new PolishNotationCalculator("8.800 / 5.55 + 3.5 + 3.5");
                double actual = pol.Calculate();
                double expected = 8.800 / 5.55 + 3.5 + 3.5;
                
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
