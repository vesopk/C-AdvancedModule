using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinersTask
{
    public class MinersTask
    {
        public static void Main()
        {
            var resourses = new Dictionary<string, int>();
            var command = Console.ReadLine();
            var count = 1;
            var resourse = string.Empty;

            while (true)
            {
                if (command == "stop")
                {
                    break;
                }

                if (count % 2 == 0)
                {
                    var quantity = int.Parse(command);
                    if (!resourses.ContainsKey(resourse))
                    {
                        resourses[resourse] = quantity;
                    }
                    else
                    {
                        resourses[resourse] += quantity;
                    }
                }
                else
                {
                    resourse = command;
                }
                count++;
                command = Console.ReadLine();
            }
            foreach (var rs in resourses)
            {
                Console.WriteLine($"{rs.Key} -> {rs.Value}");
            }
        }
    }
}
