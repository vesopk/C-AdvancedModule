using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperStrings
{
    public static class UpperStrings
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split().ToList();
            words.Select(w => w.ToUpper())
                .ToList()
                .ForEach(w => Console.Write(w + " "));
        }
    }
}
