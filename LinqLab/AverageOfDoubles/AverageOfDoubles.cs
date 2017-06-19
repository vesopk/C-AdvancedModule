using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfDoubles
{
   public static class AverageOfDoubles
    {
       public static void Main()
        {
            Console.WriteLine($"{Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray().Average():F2}");
        }
    }
}
