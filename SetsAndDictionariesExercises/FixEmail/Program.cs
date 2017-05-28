using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    public class FixEmails
    {
        public static void Main()
        {
            var namesAndEmails = new Dictionary<string, string>();

            var command = Console.ReadLine();
            var count = 1;
            string name = null;
            string email = null;

            while (true)
            {
                if (command == "stop")
                {
                    break;
                }
                if (count % 2 == 1)
                {
                    name = command;
                }
                else
                {
                    var emailParams = command.Split('.').ToList();
                    if (emailParams[1] != "uk" && emailParams[1] != "us")
                    {
                        email = command;
                        if (!namesAndEmails.ContainsKey(name))
                        {
                            namesAndEmails[name] = email;
                        }
                        else
                        {
                            namesAndEmails[name] = email;
                        }
                    }
                    else
                    {
                        name = null;
                    }

                }
                count++;
                command = Console.ReadLine();
            }
            foreach (var nm in namesAndEmails)
            {
                Console.WriteLine($"{nm.Key} -> {nm.Value}");
            }
        }
    }
}
