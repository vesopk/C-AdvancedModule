using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddVat
{
    public static class AddVat
    {
        public static void Main()
        {
            var numbers =
               Console.ReadLine()
                   .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(double.Parse)
                   .ToArray();

            foreach (var number in numbers)
            {
                var numberWithVat = number + (number * 0.2);
                Console.WriteLine($"{numberWithVat:F2}");
            }
        }
    }
}
