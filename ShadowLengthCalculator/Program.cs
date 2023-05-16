using System;

namespace ShadowLengthCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Segment> segments = new List<Segment>()
            {
                new Segment(-50,-30),
                new Segment(-40,-10),
                new Segment(-10,10),
                new Segment(10,40),
            };
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Calc(segments));
        }
    }
}