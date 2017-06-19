using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEvensOrOdds
{
   public static class FindEvensOrOdds
    {
        public static void Main()
        {
            var boundries = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var lower = boundries[0];
            var higher = boundries[1];
            var numbers = new List<int>();

            for (int i = lower; i <= higher; i++)
            {
                numbers.Add(i);
            }
            var command = Console.ReadLine();

            var result = Predicate(numbers, command);

            Console.WriteLine(string.Join(" ",result));
        }

        public static List<int> Predicate(List<int> numbers, string command)
        {
            if (command == "odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        numbers.RemoveAt(i);
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        numbers.RemoveAt(i);
                    }
                }
            }
            return numbers;
        }
    }
}
