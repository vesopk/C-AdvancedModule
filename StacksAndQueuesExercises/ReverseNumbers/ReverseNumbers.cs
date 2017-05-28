using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNumbers
{
    public class ReverseNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
            var stack = new Stack<int>();

            foreach (var number in numbers)
            {
                stack.Push(number);
            }
            for (int i = 0; i < numbers.Count(); i++)
            {
                Console.Write(stack.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}
