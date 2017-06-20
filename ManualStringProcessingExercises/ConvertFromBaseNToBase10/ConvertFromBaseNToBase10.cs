using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConvertFromBaseNToBase10
{
    public static class ConvertFromBaseNToBase10
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToList();

            var n = numbers[0];
            var number = numbers[1];
        }
    }
}
