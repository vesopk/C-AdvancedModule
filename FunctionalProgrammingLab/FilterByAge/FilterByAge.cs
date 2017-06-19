using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterByAge
{
   public static class FilterByAge
    {
       public static void Main()
       {
           var count = int.Parse(Console.ReadLine());

           var nameAndAge = new Dictionary<string, int>();

            for (int i = 0; i < count; i++)
            {
                var currentPerson = Console.ReadLine().Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries);
                var name = currentPerson[0];
                var age = int.Parse(currentPerson[1]);

                if (!nameAndAge.ContainsKey(name))
                {
                    nameAndAge[name] = new int();
                }
                nameAndAge[name] = age;
            }
           var firstCommand = Console.ReadLine();
           var secondCommand = int.Parse(Console.ReadLine());
           var thirdCommand = Console.ReadLine();

           if (firstCommand == "older") 
            {
                if (thirdCommand == "name")
                {
                    foreach (var name in nameAndAge.Where(n => n.Value >= secondCommand))
                    {
                        Console.WriteLine(name.Key);
                    }
                }
                else if (thirdCommand == "age")
                {
                    foreach (var name in nameAndAge.Where(n => n.Value >= secondCommand))
                    {
                        Console.WriteLine(name.Value);
                    }
                }
                else
                {
                    foreach (var name in nameAndAge.Where(n => n.Value >= secondCommand))
                    {
                        Console.WriteLine($"{name.Key} - {name.Value}");
                    }
                }
            }
           
           else
           {
                if (thirdCommand == "name")
                {
                    foreach (var name in nameAndAge.Where(n => n.Value < secondCommand))
                    {
                        Console.WriteLine(name.Key);
                    }
                }
                else if (thirdCommand == "age")
                {
                    foreach (var name in nameAndAge.Where(n => n.Value < secondCommand))
                    {
                        Console.WriteLine(name.Value);
                    }
                }
                else
                {
                    foreach (var name in nameAndAge.Where(n => n.Value < secondCommand))
                    {
                        Console.WriteLine($"{name.Key} - {name.Value}");
                    }
                }
            }
           
       }
    }
}
