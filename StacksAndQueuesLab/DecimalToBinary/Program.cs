using System;
using System.Collections.Generic;

namespace DecimalToBinary
{
    public class DecimalToBinary
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                var stack = new Stack<int>();

                while (number >= 2)
                {
                    var remainderToAdd = number % 2;
                    stack.Push(remainderToAdd);
                    number /= 2;
                }
                stack.Push(number);
                Console.WriteLine(string.Join("", stack));
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
