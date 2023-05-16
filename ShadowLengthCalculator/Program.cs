using System;

namespace ShadowLengthCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Segment> segments = new List<Segment>()
            {
                new Segment(10,30),
                new Segment(20,40),
                new Segment(50,70),
                new Segment(60,90)
            };
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Calc(segments));
        }
    }
}