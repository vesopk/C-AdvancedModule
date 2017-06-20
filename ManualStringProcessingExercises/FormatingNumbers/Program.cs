using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatingNumbers
{
   public static class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            var hexNumber = string.Format("{0:X}", int.Parse(numbers[0]));
            var binaryNum = Convert.ToString(int.Parse(numbers[0]), 2).PadLeft(10, '0');
            var fristFloatNumber = string.Format($"{double.Parse(numbers[1]):F2}");
            var secondFloatNumber = string.Format($"{double.Parse(numbers[2]):F3}");

            if (binaryNum.Length > 10)
            {
                binaryNum = binaryNum.Substring(0, 10);
            }

            Console.WriteLine("|{0,-10}|{1}|{2,10}|{3,-10}|",hexNumber,binaryNum,fristFloatNumber,secondFloatNumber);
        }
    }
}
