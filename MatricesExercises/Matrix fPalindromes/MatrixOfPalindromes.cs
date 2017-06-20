using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalindromes
{
   public static class MatrixOfPalindromes
    {
       public static void Main()
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var dimensions = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            var rows = dimensions[0];
            var cols = dimensions[1];

            var matrix = new string[rows][];

            for (int rowsIndex = 0; rowsIndex < rows; rowsIndex++)
            {
                matrix[rowsIndex] = new string[cols];
                for (int colsIndex = 0; colsIndex < cols; colsIndex++)
                {
                    var palindromToAdd = $"{alphabet[rowsIndex]}{alphabet[rowsIndex + colsIndex]}{alphabet[rowsIndex]}";
                    matrix[rowsIndex][colsIndex] = palindromToAdd;
                }
            }
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
