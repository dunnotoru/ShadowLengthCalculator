using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShadowLengthCalculator;
using System.Collections.Generic;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTestClass
    {
        [TestMethod]
        public void CalcTest1()
        {
            List<Segment> segments = new List<Segment>()
            {
                new Segment(-50,-30),
                new Segment(-40,-10),
                new Segment(-10,10),
                new Segment(10,40),
            };

            double expected = 90;
            Calculator calculator = new Calculator();
            double actual = calculator.Calc(segments);
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcTest2()
        {
            List<Segment> segments = new List<Segment>()
            {
                new Segment(-50,-30),
                new Segment(-10, 10),
                new Segment(10,40),
            };

            double expected = 70;
            Calculator calculator = new Calculator();
            double actual = calculator.Calc(segments);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcTest3()
        {
            List<Segment> segments = new List<Segment>()
            {
                new Segment(1,4),
                new Segment(3, 7),
                new Segment(10,15),
            };

            double expected = 11;
            Calculator calculator = new Calculator();
            double actual = calculator.Calc(segments);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcTest4()
        {
            List<Segment> segments = new List<Segment>()
            {
                new Segment(4,1),
                new Segment(3, 7),
                new Segment(15,10),
            };

            double expected = 11;
            Calculator calculator = new Calculator();
            double actual = calculator.Calc(segments);

            Assert.AreEqual(expected, actual);
        }
    }
}