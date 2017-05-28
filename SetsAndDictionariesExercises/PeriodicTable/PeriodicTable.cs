using System;
using System.Collections.Generic;

namespace PeriodicTable
{
   public class PeriodicTable
    {
       public static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            var elements = new SortedSet<string>();
            for (int i = 0; i < count; i++)
            {
                var currentElements = Console.ReadLine().Split();
                for (int j = 0; j < currentElements.Length; j++)
                {
                    elements.Add(currentElements[j]);
                }
            }
            Console.WriteLine(string.Join(" ",elements));
        }
    }
}
