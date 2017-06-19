using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedArithmetics
{
    public static class AppliedArithmetics
    {
        public static void Main()
        {
            var numbers =
                Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var input = Console.ReadLine();
            while (true)
            {
                if (input == "end")
                {
                    break;
                }
                if (input == "add")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] += 1;
                    }
                }
                else if (input == "multiply")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] *= 2;
                    }
                }
                else if (input == "subtract")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] -= 1;
                    }
                }
                else if (input == "print")
                {
                    Console.WriteLine(string.Join(" ",numbers));
                }
                input = Console.ReadLine();
            }
        }
    }
}
