using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoundedNumbers
{
   public static class BoundedNumbers
    {
       public static void Main()
       {
           var bounds = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           var lowerBound = Math.Min(bounds[0], bounds[1]);
           var higherBound = Math.Max(bounds[0], bounds[1]);
           var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           numbers.Where(n => n >= lowerBound && n <= higherBound).ToList().ForEach(n => Console.Write(n + " "));
           Console.WriteLine();
       }
    }
}
