using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinEvenNumber
{
    public static class MinEvenNumber
    {
        public static void Main()
        {
            try
            {
                var min = Console.ReadLine()
               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(double.Parse)
               .ToArray()
               .Where(n => n % 2 == 0)
               .Min();

                Console.WriteLine($"{min:F2}");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("No match");
            }

        }
    }
}
