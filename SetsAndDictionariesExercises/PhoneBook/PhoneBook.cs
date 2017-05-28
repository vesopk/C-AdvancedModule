using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneBook
    {
       public static void Main()
        {
            var phonebook = new Dictionary<string, string>();
            var input = Console.ReadLine();

            while (true)
            {
                if (input == "search")
                {
                    break;
                }

                var contactInfo = input.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                var contactName = contactInfo[0];
                var contactNumber = contactInfo[1];

                if (!phonebook.ContainsKey(contactName))
                {
                    phonebook[contactName] = contactNumber;
                }
                else
                {
                    phonebook[contactName] = contactNumber;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (true)
            {
                if (input == "stop")
                {
                    break;
                }
                if (phonebook.ContainsKey(input))
                {
                    Console.WriteLine($"{input} -> {phonebook[input]}");
                }
                else
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                }
                input = Console.ReadLine();
            }
        }
    }
}
