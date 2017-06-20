using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace VowelCount
{
    public static class VowelCount
    {
       public static void Main()
        {
            var pattern = @"[aeiyou]";

            var text = Console.ReadLine().ToLower();

            var regex = new Regex(pattern);
            var matches = regex.Matches(text);
            var count = 0;

            foreach (Match match in matches)
            {
                count++;
            }

            Console.WriteLine($"Vowels: {count}");
        }
    }
}
