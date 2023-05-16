using System;

namespace ShadowLengthCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Segment> segments = new List<Segment>()
            {
                new Segment(1,4),
                new Segment(3,7),
                new Segment(10,13),
                new Segment(13,15)
            };
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Calc(segments));
        }
    }
}