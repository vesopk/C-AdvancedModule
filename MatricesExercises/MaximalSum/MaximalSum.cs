using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
   public static class MaximalSum
    {
       public static void Main()
        {
            var dimentions = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            var rows = dimentions[0];
            var cols = dimentions[1];

            var matrix = new long[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            }

            var sum = 0L;
            var maxCol = 0;
            var maxRow = 0;

            var resultMatrix = new long[3][];

            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                    var calcSum = CalcSum(i,j,matrix);
                    if (calcSum > sum)
                    {
                        sum = calcSum;
                        maxCol = j;
                        maxRow = i;
                    }
                }
            }
            Console.WriteLine($"Sum = {sum}");
            PrintMatrix(matrix,maxRow,maxCol);
        }
        public static long CalcSum(int startRow, int startCol, long[][] matrix)
        {
            var sum = 0L;
            for (int row = startRow; row < startRow + 3; row++)
            {
                for (int col = startCol; col < startCol + 3; col++)
                {
                    sum = sum + matrix[row][col];
                }
            }

            return sum;
        }
        private static void PrintMatrix(long[][] matrix, int maxRow, int maxCol)
        {
            for (int rows = maxRow; rows <= maxRow + 2; rows++)
            {
                for (int cols = maxCol; cols <= maxCol + 2; cols++)
                {
                    Console.Write(matrix[rows][cols] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
