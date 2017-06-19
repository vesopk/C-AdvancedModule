using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsOfHonor
{
    public static class KnightsOfHonor
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            AddTitleAndPrint(names);
        }

        public static void AddTitleAndPrint(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Sir {names[i]}");
            }
        }
    }
}
