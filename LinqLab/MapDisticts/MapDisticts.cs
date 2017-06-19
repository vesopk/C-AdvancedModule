using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapDisticts
{
    public static class MapDisticts
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var citiesAndPopulation = new Dictionary<string,List<long>>();
            foreach (var words in text)
            {
                var currentCity = words.Trim().Split(':');
                var cityName = currentCity[0];
                var population = long.Parse(currentCity[1]);

                if (!citiesAndPopulation.ContainsKey(cityName))
                {
                    citiesAndPopulation[cityName] = new List<long>();
                }
                citiesAndPopulation[cityName].Add(population);
            }
            var condition = long.Parse(Console.ReadLine());
            foreach (var city in citiesAndPopulation.Where(c => c.Value.Sum() >= condition).OrderByDescending(c => c.Value.Sum()))
            {
                Console.WriteLine($"{city.Key}: {string.Join(" ",city.Value.OrderByDescending(c => c).Take(5))}");
            }
        }
    }
}
