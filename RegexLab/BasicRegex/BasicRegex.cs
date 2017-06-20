using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BasicRegex
{
    public static class BasicRegex
    {
        public static void Main()
        {
            var pattern = Console.ReadLine();
            var text = Console.ReadLine();

            var count = 0;

            var regex = new Regex(pattern);
            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
