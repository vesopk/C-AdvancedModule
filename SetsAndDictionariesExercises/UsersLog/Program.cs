using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UsersLog
{
    public class UsersLog
    {
        public static void Main()
        {
            var pattern = @"IP=(?<IP>.+) message=(?<message>.+) user=(?<User>.+)";
            var regex = new Regex(pattern);
            var users = new Dictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine();
            while (true)
            {
                if (input == "end")
                {
                    break;
                }
                var matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    var ip = match.Groups["IP"].Value;
                    var user = match.Groups["User"].Value;
                    if (!users.ContainsKey(user))
                    {
                        users[user] = new Dictionary<string, int>();
                    }
                    if (!users[user].ContainsKey(ip))
                    {
                        users[user][ip] = 1;
                    }
                    else
                    {
                        users[user][ip]++;
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var user in users.Keys.OrderBy(u => u))
            {
                Console.WriteLine($"{user}: ");
                foreach (var ips in users[user])
                {
                    var last = users[user].Last().Key;

                    if (ips.Key != last)
                    {
                        Console.Write($"{ips.Key} => {ips.Value}, ");
                    }
                    else
                    {
                        Console.Write($"{ips.Key} => {ips.Value}.");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
