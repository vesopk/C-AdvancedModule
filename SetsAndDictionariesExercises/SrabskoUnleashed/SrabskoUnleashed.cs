using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace SrabskoUnleashed
{
    public class SrabskoUnleashed
    {
        public static void Main()
        {
            var pattern = @"(?<Singer>([a-zA-Z]+\s){1,3})@(?<Venue>([a-zA-Z]+\s){1,3})(?<TicketPrice>\d+)\s(?<PeopleCount>\d+)";

            var singersAndVenues = new Dictionary<string, Dictionary<string, decimal>>();

            var input = Console.ReadLine();

            while (true)
            {
                if (input == "End")
                {
                    break;
                }
                var regex = new Regex(pattern);

                var matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    var singer = match.Groups["Singer"].Value.Trim();
                    var venue = match.Groups["Venue"].Value.Trim();
                    var ticketPrice = decimal.Parse(match.Groups["TicketPrice"].Value);
                    var peopleCount = decimal.Parse(match.Groups["PeopleCount"].Value);
                    var totalMoney = ticketPrice * peopleCount;

                    if (!singersAndVenues.ContainsKey(venue))
                    {
                        singersAndVenues[venue] = new Dictionary<string, decimal>();
                    }
                    if (!singersAndVenues[venue].ContainsKey(singer))
                    {
                        singersAndVenues[venue][singer] = totalMoney;
                    }
                    else
                    {
                        singersAndVenues[venue][singer] += totalMoney;
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var venue in singersAndVenues.Keys)
            {
                Console.WriteLine($"{venue}");
                foreach (var singer in singersAndVenues[venue].OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
