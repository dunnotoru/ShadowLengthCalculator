using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowLengthCalculator
{
    public struct Segment
    {
        public double StartCoord;
        public double EndCoord;

        public Segment(double startCoord,double endCoord)
        {
            StartCoord = startCoord <= endCoord ? startCoord : endCoord;
            EndCoord = endCoord >= startCoord ? endCoord : startCoord;
        }
    }
    public class Calculator
    {
        public double LeftBorder { get; set;} 
        public double RightBorder { get; set;}

        public Calculator(double leftBorder = Double.MinValue, double rightBorder = Double.MaxValue)
        {
            LeftBorder = leftBorder <= rightBorder ? leftBorder : rightBorder;
            RightBorder = rightBorder >= leftBorder ? rightBorder : leftBorder;
        }

        public double Calc(List<Segment> segments)
        {
            double shadowLength = 0;
            segments = segments.OrderBy(x => x.StartCoord).ToList();
            if(segments.Count(x => x.StartCoord < LeftBorder || x.EndCoord > RightBorder) > 0)
                throw new ArgumentOutOfRangeException();

            shadowLength += Math.Abs(segments[0].EndCoord - segments[0].StartCoord);
            double maximum = segments[0].EndCoord;

            for (int i = 0; i < segments.Count - 1; i++)
            {
                if (segments[i + 1].StartCoord > segments[i].EndCoord)
                    shadowLength += Math.Abs(segments[i + 1].EndCoord - segments[i + 1].StartCoord);
                else if (segments[i + 1].EndCoord > maximum)
                    shadowLength += Math.Abs(segments[i + 1].EndCoord - maximum);
                
                maximum = segments[i+1].EndCoord;
            }

            return shadowLength;
        }
    }

    
}
