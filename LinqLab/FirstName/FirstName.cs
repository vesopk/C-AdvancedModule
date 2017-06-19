using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstName
{
   public static class FirstName
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split().ToList();
            var letters = Console.ReadLine().Split().ToList();
            var result = new List<string>();
            foreach (var name in names)
            {
                foreach (var letter in letters)
                {
                    if (string.Compare(name.First().ToString(),letter,true)==0)
                    {
                        result.Add(name);
                    }
                }
            }
            if (result.Any())
            {
                Console.WriteLine(string.Join(" ",result.OrderBy(w => w).Take(1)));
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
