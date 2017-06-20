using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSumOf2X2Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixNumbers = Console.ReadLine().Split(new[] { ", "}, StringSplitOptions.RemoveEmptyEntries);
            var matrix = new int[int.Parse(matrixNumbers[0])][];

            for (int row = 0; row < int.Parse(matrixNumbers[0]); row++)
            {
                matrix[row] = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            var maxSum = int.MinValue;
            var maxSquareCol = 0;
            var maxSquareRow = 0;

            for (int row = 0; row < matrix.Length - 1; row++) 
            {
                for (int col = 0; col < matrix[row].Length - 1; col++) 
                {
                    var currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row + 1][col] + matrix[row + 1][col + 1];

                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                        maxSquareRow = row;
                        maxSquareCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxSquareRow][maxSquareCol]} {matrix[maxSquareRow][maxSquareCol + 1]}");
            Console.WriteLine($"{matrix[maxSquareRow + 1][maxSquareCol]} {matrix[maxSquareRow + 1][maxSquareCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
