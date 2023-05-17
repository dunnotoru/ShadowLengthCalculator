using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShadowLengthCalculator
{
    public class PolishNotationCalculator
    {
        public string PostfixExpression { get; set; }
        public string InfixExpression { get; set; }

        public Dictionary<char, int> OperationPriority = new()
        {
            { '(', 0 },
            { '+', 1 },
            { '-', 1 },
            { '*', 2 },
            { '/', 2 },
            { '^', 3 },
            { '~', 4 } 
        };

        public PolishNotationCalculator(string expression)
        {
            if (!Regex.IsMatch(expression, @"^[\d\-+\*\/\s\(\)\^\.\,]+$"))
                throw new ArgumentException("Input string contains invalid characters");

            InfixExpression = expression.Replace(" ", "").Replace(".", ",");
            PostfixExpression = ConvertToPostfix();
        }

        public string GetNumberString(string expression, ref int position)
        {
            StringBuilder strNumber = new StringBuilder();

            for (; position < expression.Length; position++)
            {
                char number = expression[position];
                if (Char.IsDigit(number))
                {
                    strNumber.Append(number);
                }
                else if (number == ',')
                {
                    strNumber.Append(number);
                }
                else
                {
                    position--;
                    break;
                }
            }

            return strNumber.ToString();
        }

        public string ConvertToPostfix()
        {
            string postfixExpression = "";
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < InfixExpression.Length; i++)
            {
                char c = InfixExpression[i];
                if (Char.IsDigit(c))
                {
                    postfixExpression += GetNumberString(InfixExpression, ref i) + " ";
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                        postfixExpression += stack.Pop();
                    stack.Pop();
                }
                else if (OperationPriority.ContainsKey(c))
                {
                    char op = c;
                    if (op == '-' && (i == 0 ||
                        (i > 1 && OperationPriority.ContainsKey(InfixExpression[i - 1]))))
                        op = '~';

                    while (stack.Count > 0 && (OperationPriority[stack.Peek()] >= OperationPriority[op]))
                        postfixExpression += stack.Pop() + " ";
                    
                    stack.Push(op);
                }
            }

            foreach (char op in stack)
                postfixExpression += op;
            
            return postfixExpression;
        }

        public double Calculate()
        {
            Stack<double> locals = new Stack<double>();
            int counter = 0;

            for (int i = 0; i < PostfixExpression.Length; i++)
            {
                char c = PostfixExpression[i];
                
                if (Char.IsDigit(c))
                {
                    string number = GetNumberString(PostfixExpression, ref i);
                    locals.Push(Double.Parse(number));
                }
                else if (OperationPriority.ContainsKey(c))
                {
                    counter += 1;
                    if (c == '~')
                    {
                        double last = locals.Count > 0 ? locals.Pop() : 0;
                        locals.Push(Execute('-', 0, last));
                        Console.WriteLine($"{counter}) {c}{last} = {locals.Peek()}");
                        continue;
                    }

                    double second = locals.Count > 0 ? locals.Pop() : 0,
                    first = locals.Count > 0 ? locals.Pop() : 0;

                    locals.Push(Execute(c, first, second));
                }
            }

            return locals.Pop();
        }

        private double Execute(char op, double first, double second) => op switch
        {
            '+' => first + second,
            '-' => first - second,
            '*' => first * second,
            '/' => first / second,
            '^' => Math.Pow(first, second),
            _ => 0
        };

    }
}
