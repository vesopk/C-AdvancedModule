using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndSumIntegers
{
   public static class FindAndSumIntegers
    {
       public static void Main()
       {
           var text = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
           var numbers = new List<long>();
           foreach (var symbol in text)
           {
               long number;
               var isDigit = long.TryParse(symbol, out number);
               if (isDigit)
               {
                   numbers.Add(number);
               }
           }
           if (numbers.Any())
           {
               Console.WriteLine(numbers.Sum());
           }
           else
           {
               Console.WriteLine("No match");
           }
       }
    }
}
