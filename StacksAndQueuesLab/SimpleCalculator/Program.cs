using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class SimpleCalculator
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var stack = new Stack<int>();

            var sign = string.Empty;

            foreach (var symbol in input)
            {
                var parsedNumber = 0;

                if (int.TryParse(symbol, out parsedNumber) && (sign == string.Empty || sign == "+"))
                {
                    stack.Push(parsedNumber);
                }
                else if (int.TryParse(symbol, out parsedNumber) && sign == "-")
                {
                    var numberToPush = $"-{parsedNumber.ToString()}";
                    stack.Push(int.Parse(numberToPush));
                }
                else
                {
                    sign = symbol;
                }
            }
            Console.WriteLine(stack.Sum());
        }
    }
}
