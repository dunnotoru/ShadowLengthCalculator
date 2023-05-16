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
            StartCoord = startCoord;
            EndCoord = endCoord;
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
            segments.OrderBy(x => x.StartCoord);

            shadowLength += segments[0].EndCoord - segments[0].StartCoord;

            for (int i = 0; i < segments.Count - 1; i++)
            {
                if (segments[i + 1].StartCoord < segments[i].EndCoord)
                    shadowLength += segments[i + 1].EndCoord - segments[i].EndCoord;
                else if (segments[i + 1].StartCoord > segments[i].EndCoord)
                    shadowLength += segments[i + 1].EndCoord - segments[i+1].StartCoord;
                else if()
            }

            return shadowLength;
        }
    }

    
}
