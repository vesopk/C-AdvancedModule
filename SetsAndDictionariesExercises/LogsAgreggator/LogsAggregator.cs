using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    public class LogsAggregator
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var users = new Dictionary<string, List<string>>();
            var usersDurations = new Dictionary<string, long>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var user = input[1];
                var ip = input[0];
                var duration = long.Parse(input[2]);

                if (!users.ContainsKey(user))
                {
                    users[user] = new List<string>();
                }
                users[user].Add(ip);
                if (!usersDurations.ContainsKey(user))
                {
                    usersDurations[user] = duration;
                }
                else
                {
                    usersDurations[user] += duration;
                }
            }
            foreach (var user in users.OrderBy(u => u.Key))
            {
                Console.WriteLine($"{user.Key}: {usersDurations[user.Key]} [{string.Join(", ", user.Value.Distinct().OrderBy(ip => ip))}]");
            }
        }
    }
}
