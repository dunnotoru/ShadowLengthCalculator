using System;

namespace ShadowLengthCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Segment> segments = new List<Segment>()
            {
                new Segment(4,1),
                new Segment(3, 7),
                new Segment(10,15),
                new Segment(16,19),
            };
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Calc(segments));

            PolishNotationConverter pol = new PolishNotationConverter("2+2");
            Console.WriteLine(pol.PostfixExpression);
            Console.WriteLine(pol.Calculate());
            
        }
    }
}