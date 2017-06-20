using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtractIntegerNumbers
{
    public static class ExtractIntegerNumbers
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = @"\d+";
            var numbers = new List<long>();
            var regex = new Regex(pattern);
            var matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                numbers.Add(long.Parse(match.Value));
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
