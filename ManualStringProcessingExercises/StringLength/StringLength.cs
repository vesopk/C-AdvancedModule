using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    public static class StringLength
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            if (text.Length == 20)
            {
                Console.WriteLine(text);
            }
            else if (text.Length > 20)
            {
                var sub = text.Substring(0, 20);
                Console.WriteLine(sub);
            }
            else
            {
                text = text.PadRight(20,'*');
                Console.WriteLine(text);
            }
        }
    }
}
