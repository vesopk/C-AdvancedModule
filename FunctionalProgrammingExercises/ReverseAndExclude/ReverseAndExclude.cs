using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAndExclude
{
    public static class ReverseAndExclude
    {
       public static void Main()
       {
           var numbers =
               Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
           var n = int.Parse(Console.ReadLine());

            ReverseAndExcludeNums(numbers,n);

           Console.WriteLine(string.Join(" ",numbers));
       }

        public static void ReverseAndExcludeNums(List<int> numbers, int n)
        {
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int tmp = numbers[i];
                numbers[i] = numbers[numbers.Count - i - 1];
                numbers[numbers.Count - i - 1] = tmp;
            }
            var j = 0;

            while (true)
            {
                if (j >= numbers.Count)
                {
                    break;
                }
                if (numbers[j] % n == 0) 
                {
                    numbers.RemoveAt(j);
                }
                else
                {
                    j++;
                }
            }
        }
    }
}
