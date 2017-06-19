using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortEvenNumbers
{
   public static class SortEvenNumbers
    {
        public static void Main()
        {
            var numbers =
                Console.ReadLine()
                    .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .Where(n => n % 2 == 0)
                    .OrderBy(n => n)
                    .ToArray();

            Console.WriteLine(string.Join(", ",numbers));

        }
    }
}
