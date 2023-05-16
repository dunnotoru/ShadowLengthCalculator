using System;

namespace ShadowLengthCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Segment> segments = new List<Segment>()
            {
                new Segment(0,0),
                new Segment(-10,10),
                new Segment(-50,-30),
                new Segment(0,40),
            };
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Calc(segments));

            List<int> l = new List<int>() { 2, 3, 54, 5, 6, 0, -123 };

        }
    }
}