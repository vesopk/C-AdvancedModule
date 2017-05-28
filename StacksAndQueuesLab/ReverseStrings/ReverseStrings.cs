using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    public class ReverseStrings
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();

            var stack = new Stack<char>();

            foreach (var symbol in input)
            {
                stack.Push(symbol);
            }
            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = stack.Pop();
                Console.Write(currentChar);
            }
            Console.WriteLine();
        }
    }
}
