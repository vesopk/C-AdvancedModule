using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2x2SquaresInMatrix
{
   public static class _2x2SquaresInMatrix
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];
            var matrix = new string[rows][];

            for (int rowsIndex = 0; rowsIndex < rows; rowsIndex++)
            {
                matrix[rowsIndex] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            var count = 0;

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    var symbol = matrix[i][j];
                    if (matrix[i][j] == symbol && matrix[i + 1][j] == symbol && matrix[i][j + 1] == symbol && matrix[i + 1][j + 1] == symbol) 
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
