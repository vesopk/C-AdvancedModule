using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Non_DigitCount
{
    public static class Non_DigitCount
    {
        public static void Main()
        {
            var pattern = @"\D";
            var text = Console.ReadLine();
            var regex = new Regex(pattern);
            var matches = regex.Matches(text);
            var count = 0;
            foreach (Match match in matches)
            {
                count++;
            }
            Console.WriteLine($"Non-digits: {count}");
        }
    }
}
