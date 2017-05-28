using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGraduation
{
   public class AcademyGraduation
    {
       public static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            var studentAndGrade = new Dictionary<string, List<double>>();

            var studentName = string.Empty;
            var grades = new List<double>();

            for (int i = 0; i < count * 2; i++)
            {
                var input = Console.ReadLine();
                if (i % 2 == 0)
                {
                    studentName = input;
                }
                else if (i % 2 != 0)
                {
                    grades = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(double.Parse).ToList();

                    if (!studentAndGrade.ContainsKey(studentName))
                    {
                        studentAndGrade[studentName] = grades;
                    }
                    else
                    {
                        studentAndGrade[studentName].AddRange(grades);
                    }
                }
                
            }

            foreach (var student in studentAndGrade.OrderBy(s => s.Key))
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value.Average()}");
            }

        }
    }
}
