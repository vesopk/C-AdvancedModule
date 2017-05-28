using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCenter
{
    public class PopulationCenter
    {
        public static void Main()
        {
            var countryPopulation = new Dictionary<string, Dictionary<string, long>>();
            var input = Console.ReadLine();
            while (true)
            {
                if (input == "report")
                {
                    break;
                }

                var countryInfo = input
                    .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var city = countryInfo[0];
                var country = countryInfo[1];
                var populationOfCity = long.Parse(countryInfo[2]);

                if (!countryPopulation.ContainsKey(country))
                {
                    countryPopulation[country] = new Dictionary<string, long>();
                }
                if (!countryPopulation[country].ContainsKey(city))
                {
                    countryPopulation[country][city] = populationOfCity;
                }
                else
                {
                    countryPopulation[country][city] += populationOfCity;
                }

                input = Console.ReadLine();
            }

            foreach (var country in countryPopulation.OrderByDescending(c => c.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in countryPopulation[country.Key].OrderByDescending(ct => ct.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
