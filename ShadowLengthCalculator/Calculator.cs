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
            if (startCoord < endCoord)
            {
                StartCoord = startCoord;
                EndCoord = endCoord;
            }
            else
            {
                StartCoord = endCoord;
                EndCoord = startCoord;
            }
        }
    }
    public class Calculator
    {
        public Calculator()
        {

        }

        public double Calc(List<Segment> segments)
        {
            double shadowLength = 0;
            segments = segments.OrderBy(x => x.StartCoord).ToList();
            

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
