using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube
{
   public static class RubiksCube
    {
       public static void Main()
        {
            var dimentions = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var rows = dimentions[0];
            var cols = dimentions[1];

            var matrix = new int[rows][];
            CreateMatrix(rows, cols, matrix);

            var commandsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandsCount; i++)
            {
                var command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var rcIndex = int.Parse(command[0]);
                var direction = command[1];
                var moves = int.Parse(command[2]);

                if (direction == "up")
                {
                    MoveCol(matrix,rcIndex,moves);
                }
                else if (direction == "down")
                {
                    MoveCol(matrix, rcIndex, matrix.Length - moves % matrix.Length);
                }
                else if (direction == "left")
                {
                    MoveRow(matrix,rcIndex,moves);
                }
                else if (direction == "right")
                {
                    MoveRow(matrix, rcIndex, matrix[0].Length - moves % matrix[0].Length);
                }
            }

            var element = 1;

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[0].Length; colIndex++)
                {
                    if (matrix[rowIndex][colIndex] == element)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int r = 0; r < matrix.Length; r++)
                        {
                            for (int c = 0; c < matrix[0].Length; c++)
                            {
                                if (matrix[r][c] == element)
                                {
                                    var currentElement = matrix[rowIndex][colIndex];
                                    matrix[rowIndex][colIndex] = element;
                                    matrix[r][c] = currentElement;
                                    Console.WriteLine($"Swap ({rowIndex}, {colIndex}) with ({r}, {c})");
                                }
                            }
                        }
                    }
                    element++;
                }
            }

        }

        private static void MoveRow(int[][] matrix, int rcIndex, int moves)
        {
            var temp = new int[matrix[0].Length];

            for (int colIndex = 0; colIndex < matrix[0].Length; colIndex++)
            {
                temp[colIndex] = matrix[rcIndex][(colIndex + moves) % matrix[0].Length];
            }
            matrix[rcIndex] = temp;
        }

        private static void MoveCol(int[][] matrix, int rcIndex, int moves)
        {
            var temp = new int[matrix.Length];

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                temp[rowIndex] = matrix[(rowIndex + moves) % matrix.Length][rcIndex];
            }
            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex][rcIndex] = temp[rowIndex];
            }
        }

        private static void CreateMatrix(int rows, int cols, int[][] matrix)
        {
            var count = 1;

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = count;
                    count++;
                }
            }
        }
    }
}
