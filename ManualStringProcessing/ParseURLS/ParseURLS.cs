using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseURLS
{
    public static class ParseURLS
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var inputTokens = input.Split(new[] { "://" }, StringSplitOptions.RemoveEmptyEntries);

            if (inputTokens.Length != 2 || inputTokens[1].IndexOf('/') == -1)
            {
                Console.WriteLine("Invalid URL");
            }
            else
            {
                var protocol = inputTokens[0];
                var indexRecource = inputTokens[1].IndexOf('/');
                var server = inputTokens[1].Substring(0, indexRecource);
                var resource = inputTokens[1].Substring(indexRecource + 1);
                Console.WriteLine($"Protocol = {protocol}");
                Console.WriteLine($"Server = {server}");
                Console.WriteLine($"Resources = {resource}");
            }
            
        }
    }
}
