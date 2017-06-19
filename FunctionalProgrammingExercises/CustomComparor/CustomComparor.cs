using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomComparor
{
    public static class CustomComparor
    {
        public static void Main()
        {
            var numbers =
                Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            SortNumbersAndPrint(numbers);
        }

        private static void SortNumbersAndPrint(List<int> numbers)
        {
            var evenNumbers = numbers.Where(n => n % 2 == 0).OrderBy(n => n).ToList();
            var oddNumbers = numbers.Where(n => n % 2 != 0).OrderBy(n => n).ToList();
            numbers = evenNumbers.Concat(oddNumbers).ToList();
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
