using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMatricesElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixNumbers = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var matrix = new int[matrixNumbers[0], matrixNumbers[1]];

            for (int i = 0; i < matrixNumbers[0]; i++)
            {
                var numbers = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < numbers.Length; j++)
                {
                    matrix[i,j] = numbers[j];
                }  
            }

            var sum = 0;

            for (int i = 0; i < matrixNumbers[0]; i++)
            {
                for (int j = 0; j < matrixNumbers[1]; j++)
                {
                    sum += matrix[i, j];
                }
                
            }

            Console.WriteLine(matrixNumbers[0]);
            Console.WriteLine(matrixNumbers[1]);
            Console.WriteLine(sum);
        }
    }
}
