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
                new Segment(0,40),
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
                new Segment(13,15),
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
                new Segment(13,15),
                new Segment(10,15),
                new Segment(3, 7),
                new Segment(1,4),
            };

            double expected = 11;
            Calculator calculator = new Calculator();
            double actual = calculator.Calc(segments);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcTest5()
        {
            List<Segment> segments = new List<Segment>()
            {
                new Segment(4,1),
                new Segment(3, 7),
                new Segment(15,10),
                new Segment(13,15),
            };

            double expected = 11;
            Calculator calculator = new Calculator();
            double actual = calculator.Calc(segments);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcTest6()
        {
            List<Segment> segments = new List<Segment>()
            {
                new Segment(-50,-30),
                new Segment(-40, -10),
                new Segment(-10,10),
                new Segment(1,1),
                new Segment(10,40),
            };

            double expected = 90;
            Calculator calculator = new Calculator();
            double actual = calculator.Calc(segments);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcTest7()
        {
            List<Segment> segments = new List<Segment>()
            {
                new Segment(-3.5,-2.5),
                new Segment(-2, -1),
                new Segment(-1.5,0),
                new Segment(1,3),
            };

            double expected = 5;
            Calculator calculator = new Calculator();
            double actual = calculator.Calc(segments);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcTest8()
        {
            List<Segment> segments = new List<Segment>()
            {
                new Segment(-2.5,-3.5),
                new Segment(-2, -1),
                new Segment(0,-1.5),
                new Segment(3,1),
            };

            double expected = 5;
            Calculator calculator = new Calculator();
            double actual = calculator.Calc(segments);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcTest9()
        {
            List<Segment> segments = new List<Segment>()
            {
                new Segment(-2, -1),
                new Segment(1,3),
                new Segment(-1.5,0),
                new Segment(-3.5,-2.5),
            };

            double expected = 5;
            Calculator calculator = new Calculator();
            double actual = calculator.Calc(segments);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcTest10()
        {
            List<Segment> segments = new List<Segment>()
            {
                new Segment(-3.5, -2.5),
                new Segment(-3,-1.5),
                new Segment(-2,1.5),
                new Segment(0,0),
            };

            double expected = 5;
            Calculator calculator = new Calculator();
            double actual = calculator.Calc(segments);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcTest11()
        {
            List<Segment> segments = new List<Segment>()
            {
                new Segment(-3.5, -2.5),
                new Segment(20,20),
                new Segment(-2,1.5),
                new Segment(-3,-1.5),
            };

            double expected = 5;
            Calculator calculator = new Calculator();
            double actual = calculator.Calc(segments);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcTest12()
        {
            List<Segment> segments = new List<Segment>()
            {
                new Segment(-3.5, -2.5),
                new Segment(-40,-40),
                new Segment(-2,1.5),
                new Segment(-3,-1.5),
            };

            double expected = 5;
            Calculator calculator = new Calculator();
            double actual = calculator.Calc(segments);

            Assert.AreEqual(expected, actual);
        }
    }
}