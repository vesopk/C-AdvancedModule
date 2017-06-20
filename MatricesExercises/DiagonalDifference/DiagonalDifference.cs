using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
   public static class DiagonalDifference
    {
       public static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
           
            var matrix = new int[size][];

            for (int rowsIndex = 0; rowsIndex < size; rowsIndex++)
            {
                matrix[rowsIndex] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            var leftDiagonalSum = 0;
            var rightDiagonalSum = 0;

            for (int i = 0; i < size; i++)
            {
                leftDiagonalSum += matrix[i][i];
            }
            var j = size - 1;
            for (int i = 0; i < size; i++)
            {
                rightDiagonalSum += matrix[i][j];
                j--;
            }

            var result = Math.Abs(leftDiagonalSum - rightDiagonalSum);

            Console.WriteLine(result);
        }
    }
}
