using System;
using System.Collections.Generic;
using System.Linq;

class MaximumElement
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var numberStack = new Stack<int>();
        var maxNumberStack = new Stack<int>();
        var maxNumber = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            var commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (commands[0] == 1)
            {
                numberStack.Push(commands[1]);
                if (commands[1] >= maxNumber)
                {
                    maxNumber = commands[1];
                    maxNumberStack.Push(maxNumber);
                }
            }
            else if (commands[0] == 2)
            {
                var numberToPop = numberStack.Pop();
                var currentMaxNumber = maxNumberStack.Peek();
                if (numberToPop == currentMaxNumber)
                {
                    maxNumberStack.Pop();
                    if (maxNumberStack.Count > 0)
                    {
                        maxNumber = maxNumberStack.Peek();
                    }
                    else
                    {
                        maxNumber = int.MinValue;
                    }
                }
            }

            else
            {
                var max = maxNumberStack.Peek();
                Console.WriteLine(max);
            }
        }
    }
}

