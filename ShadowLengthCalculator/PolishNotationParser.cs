using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowLengthCalculator
{
    public class PolishNotationParser
    {
        public string PostfixExpression { get; set; }

        public Dictionary<char, int> OperationPriority = new()
        {
            { '(', 0 },
            { '+', 1 },
            { '-', 1 },
            { '*', 2 },
            { '/', 2 },
            { '^', 3 },
            { '~', 4 }  //	Унарный минус
        };
    }
}
