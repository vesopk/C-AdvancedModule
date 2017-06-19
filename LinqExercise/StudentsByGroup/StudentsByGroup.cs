using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsByGroup
{
    public static class StudentsByGroup
    {
        public static void Main()
        {
            var studentsByFirstName = new Dictionary<string, string>();

            var input = Console.ReadLine();
            while (true)
            {
                if (input == "END")
                {
                    break;
                }

                var tokens = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var firstName = tokens[0];
                var secondName = tokens[1];
                var group = int.Parse(tokens[2]);
                var fullName = firstName + " " + secondName;

                if (group == 2)
                {
                    if (!studentsByFirstName.ContainsKey(firstName))
                    {
                        studentsByFirstName[fullName] = string.Empty;
                    }
                    studentsByFirstName[fullName] = firstName;
                }
                input = Console.ReadLine();
            }
            foreach (var student in studentsByFirstName.OrderBy(s => s.Value))
            {
                Console.WriteLine($"{student.Key}");
            }
        }
    }
}

