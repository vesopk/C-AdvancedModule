using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractTags
{
    public static class ExtractTags
    {
        public static void Main()
        {
            var pattern = @"<.+?>";
            var regex = new Regex(pattern);

            var list = new List<string>();

            var input = Console.ReadLine();

            while (true)
            {
                if (input == "END")
                {
                    break;
                }
                var matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    list.Add(match.Value);
                }

                input = Console.ReadLine();
            }
            if (list.Any())
            {
                foreach (var tag in list)
                {
                    Console.WriteLine(tag);
                }
            }
        }
    }
}
