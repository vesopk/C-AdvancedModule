using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace StudntsResults
{
    public static class StudntsResults
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            var students = new List<Student>();
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine();

                var pattern = @"(?<Name>[a-zA-z]+) - (?<CadvGrade>\d\.*\d*), (?<COOPGrade>\d\.*\d*), (?<OOPAdvGrade>\d\.*\d*)";
                var regex = new Regex(pattern);
                var match = regex.Match(input);

                var name = match.Groups["Name"].Value;
                var cAdvGrade = double.Parse(match.Groups["CadvGrade"].Value);
                var cOOPGrade = double.Parse(match.Groups["COOPGrade"].Value);
                var cOOPAdvGrade = double.Parse(match.Groups["OOPAdvGrade"].Value);

                var currentStudent = new Student(name,cAdvGrade,cOOPGrade,cOOPAdvGrade);
                students.Add(currentStudent);
            }
            Console.WriteLine(string.Format("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|","Name","CAdv","COOP","AdvOOP","Average"));
            foreach (var student in students)
            {
                Console.WriteLine(string.Format("{0,-10}|{1,7:F2}|{2,7:F2}|{3,7:F2}|{4,7:F4}|", student.Name, student.CAdvGrade, student.COOPGrade, student.AdvOOPGrade, student.GetAverage()));
            }
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public double CAdvGrade { get; set; }
        public double COOPGrade { get; set; }
        public double AdvOOPGrade { get; set; }

        public double GetAverage()
        {
            var result = (CAdvGrade + COOPGrade + AdvOOPGrade) / 3;
            return result;
        }

        public Student(string Name , double CAdvGrade, double COOPGrade, double AdvOOPGrade)
        {
            this.Name = Name;
            this.CAdvGrade = CAdvGrade;
            this.COOPGrade = COOPGrade;
            this.AdvOOPGrade = AdvOOPGrade;
        }
    }
}
