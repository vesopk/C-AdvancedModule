using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    public static class ReverseString
    {
       public static void Main()
        {
            var text = Console.ReadLine().ToCharArray();
            var sb = new StringBuilder();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
