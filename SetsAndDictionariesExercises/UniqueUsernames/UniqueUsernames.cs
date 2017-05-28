using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueUsernames
{
   public class UniqueUsernames
    {
       public static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            var uniqueUsers = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                var currentUser = Console.ReadLine();
                uniqueUsers.Add(currentUser);
            }
            foreach (var user in uniqueUsers)
            {
                Console.WriteLine(user);
            }
        }
    }
}
