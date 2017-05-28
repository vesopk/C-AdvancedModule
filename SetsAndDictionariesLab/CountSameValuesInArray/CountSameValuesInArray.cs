using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSameValuesInArray
{
   public class CountSameValuesInArray
    {
       public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse);
            var numbersWithCount = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!numbersWithCount.ContainsKey(number))
                {
                    numbersWithCount[number] = 0;
                }
                numbersWithCount[number]++;
            }
            foreach (var nwc in numbersWithCount.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{nwc.Key} - {nwc.Value} times");
            }
        }
    }
}
