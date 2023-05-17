using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShadowLengthCalculator;
using System.Collections.Generic;
using System;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTestClass
    {

        [TestMethod]
        public void CalcTest1()
        {
            //�������� �� ���������� ����� ������ ��������.
            List<Segment> segments = new List<Segment>()
            {
                new Segment(1,4),
                new Segment(5,7),
                new Segment(10,13),
                new Segment(13,15),
            };

            double expected = 7;
            Calculator calculator = new Calculator();
            double actual = calculator.Calc(segments);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcTest2()
        {
            //�������� �� ��������� ������ ��������.
            List<Segment> segments = new List<Segment>()
            {
                new Segment(1,4),
                new Segment(3, 7),
                new Segment(10,14),
                new Segment(13,15),
            };

            double expected = 11;
            Calculator calculator = new Calculator();
            double actual = calculator.Calc(segments);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcTest3()
        {
            //�������� �� �����.
            List<Segment> segments = new List<Segment>()
            {
                new Segment(-50,-40),
                new Segment(-30,-20),
                new Segment(-10, 0),
                new Segment(10,10),
            };

            double expected = 40;
            Calculator calculator = new Calculator();
            double actual = calculator.Calc(segments);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcTest4()
        {
            //�������� ���������� �������� ��� �������� ������������������ �� �������.
            List<Segment> segments = new List<Segment>()
            {
                new Segment(4,1),
                new Segment(3, 7),
                new Segment(10,15),
                new Segment(16,19),
            };

            double expected = 15;
            Calculator calculator = new Calculator();
            double actual = calculator.Calc(segments);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcTest5()
        {
            //�������� ����������� �������� ��� ��������� ����� ��������.
            List<Segment> segments = new List<Segment>()
            {
                new Segment(-9, -1),
                new Segment(-20, -10),
                new Segment(-50,-30),
            };

            double expected = 38;
            Calculator calculator = new Calculator();
            double actual = calculator.Calc(segments);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcTest6()
        {
            //��� ����� ��������� ��������� ��������, ����� �������� �����������
            //���� ���������� �������� ������ ������ ���������� � �������� ���������
            //�������� �� ������������ ���� ����� �������.
            List<Segment> segments = new List<Segment>()
            {
                new Segment(-10,-7),
                new Segment(-4,-1),
                new Segment(0,3),
                new Segment(7,20),
            };

            Calculator calculator = new Calculator(0, 100);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => calculator.Calc(segments));
        }

        [TestMethod]
        public void CalcTest7()
        {
            //�������� �� ������������ ���� ������ �������.
            List<Segment> segments = new List<Segment>()
            {
                new Segment(1,21),
                new Segment(40,71),
                new Segment(80,101),
                new Segment(105,130),
            };

            Calculator calculator = new Calculator(0, 100);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => calculator.Calc(segments));
        }

        [TestMethod]
        public void CalcTest8()
        {
            //�������� �� ������������ ���� ������ � ����� �������.
            List<Segment> segments = new List<Segment>()
            {
                new Segment(-20,-10),
                new Segment(1,31),
                new Segment(80,99),
                new Segment(105,130),
            };

            Calculator calculator = new Calculator(0, 100);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => calculator.Calc(segments));
        }

        [TestMethod]
        public void CalcTest9()
        {
            //�������� �� ��������� ���� ������ � ����� �������.
            List<Segment> segments = new List<Segment>()
            {
                new Segment(0,10),
                new Segment(12,31),
                new Segment(40,80),
                new Segment(90,100),
            };

            Calculator calculator = new Calculator(0, 100);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => calculator.Calc(segments));
        }
    }
}