using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParty
{
   public class SoftUniParty
    {
       public static void Main()
        {
            var vips = new HashSet<string>();
            var regular = new HashSet<string>();

            var input = Console.ReadLine();
            
            while (true)
            {
                if (input == "PARTY")
                {
                    break;
                }
                if (char.IsDigit(input[0]))
                {
                    vips.Add(input);
                }
                else
                {
                    regular.Add(input);
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (true)
            {
                if (input == "END")
                {
                    break;
                }
                if (char.IsDigit(input[0]))
                {
                    vips.Remove(input);
                }
                else
                {
                    regular.Remove(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(vips.Count + regular.Count);
            foreach (var vip in vips.OrderBy(v => v))
            {
                Console.WriteLine(vip);
            }
            foreach (var person in regular.OrderBy(p => p))
            {
                Console.WriteLine(person);
            }
        }
    }
}
