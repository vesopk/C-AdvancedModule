using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMinFunc
{
    public class CustomMinFunc
    {
        public static void Main()
        {
            var numbers =
                Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var result = MinNumber(numbers);
            Console.WriteLine(result);
        }

        public static int MinNumber(int[] numbers)
        {
            var min = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }
    }
}
