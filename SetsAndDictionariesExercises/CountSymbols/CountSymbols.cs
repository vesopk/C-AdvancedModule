using System;
using System.Collections.Generic;

namespace CountSymbols
{
   public class CountSymbols
    {
       public static void Main()
        {
            var text = Console.ReadLine();
            var symbolsAndCount = new SortedDictionary<char, int>();

            foreach (var symbol in text)
            {
                if (!symbolsAndCount.ContainsKey(symbol))
                {
                    symbolsAndCount[symbol] = 0;
                }
                symbolsAndCount[symbol]++;
            }
            foreach (var symbolAndCount in symbolsAndCount)
            {
                Console.WriteLine($"{symbolAndCount.Key}: {symbolAndCount.Value} time/s");
            }
        }
    }
}
