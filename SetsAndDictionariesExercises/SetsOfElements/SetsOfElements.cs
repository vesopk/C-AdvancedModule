using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsOfElements
{
   public class SetsOfElements
    {
       public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var fn = numbers[0];
            var sn = numbers[1];

            var firstNumbers = new int[fn];
            var secondNumbers = new int[sn];
            var muturalNumbers = new HashSet<int>();

            for (int i = 0; i < fn; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                firstNumbers[i] = currentNumber;
            }

            for (int i = 0; i < sn; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                secondNumbers[i] = currentNumber;
            }
            foreach (var number in firstNumbers)
            {
                if (secondNumbers.Contains(number))
                {
                    muturalNumbers.Add(number);
                }
            }
            foreach (var number in secondNumbers)
            {
                if (firstNumbers.Contains(number))
                {
                    muturalNumbers.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ",muturalNumbers));
        }
    }
}
