using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    public static class ListOfPredicates
    {
        public static void Main()
        {
            var end = int.Parse(Console.ReadLine());
            var numbersToDivide =
                Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var numbers = new List<int>();

            for (int i = 1; i <= end; i++)
            {
                var isResult = true;
                foreach (var divider in numbersToDivide)
                {
                    if (i % divider != 0)
                    {
                        isResult = false;
                        break;
                    }
                }
                if (isResult)
                {
                    numbers.Add(i);
                }
            }
            Action<List<int>> print = n => Console.WriteLine(string.Join(" ", n));
            print(numbers);
        }
    }
}
