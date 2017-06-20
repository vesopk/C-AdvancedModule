using System;
using System.Collections.Generic;
namespace SpecialWords
{
    public static class SpecialWords
    {
       public static void Main()
        {
            var separators = new[] {')','(','[',']','<','>',',','-','!','?',' '};

            var specialWords = Console.ReadLine().Split(separators,StringSplitOptions.RemoveEmptyEntries);

            var text = Console.ReadLine().Split(separators,StringSplitOptions.RemoveEmptyEntries);
            var specialWordsCount = new Dictionary<string, int>();

            foreach (var specialWord in specialWords)
            {
                if (!specialWordsCount.ContainsKey(specialWord))
                {
                    specialWordsCount[specialWord] = 0;
                }
            }
            foreach (var word in text)
            {
                if (specialWordsCount.ContainsKey(word))
                {
                    specialWordsCount[word]++;
                }
            }
            foreach (var word in specialWordsCount)
            {
                Console.WriteLine($"{word.Key} - {word.Value}");
            }
        }
    }
}
