using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowLengthCalculator
{
    public struct Segment
    {
        public int StartCoord;
        public int EndCoord;

        public Segment(int startCoord,int endCoord)
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

        public int Calc(List<Segment> segments)
        {
            int shadowLength = 0;
            segments = segments.OrderBy(x => x.StartCoord).ToList();
            

            shadowLength += Math.Abs(segments[0].EndCoord - segments[0].StartCoord);

            int maximum = int.MinValue;
            for (int i = 0; i < segments.Count - 1; i++)
            {
                if (segments[i + 1].StartCoord > segments[i].EndCoord)
                {
                    shadowLength += Math.Abs(segments[i + 1].EndCoord - segments[i + 1].StartCoord);
                    maximum = segments[i+1].EndCoord;
                }
                else if (segments[i + 1].EndCoord > maximum)
                {
                    shadowLength += Math.Abs(segments[i + 1].EndCoord - maximum);
                }
            }

            return shadowLength;
        }
    }

    
}
