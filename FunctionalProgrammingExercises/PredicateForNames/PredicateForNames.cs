using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateForNames
{
   public static class PredicateForNames
    {
        public static void Main()
        {
            var wordLength = int.Parse(Console.ReadLine());
            var words = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            RemoveAndPrint(wordLength,words);
        }

        private static void RemoveAndPrint(int wordLength, List<string> words)
        {
            var wordIndex = 0;
            while (true)
            {
                if (wordIndex >= words.Count)
                {
                    break;
                }
                if (words[wordIndex].Length > wordLength)
                {
                    words.RemoveAt(wordIndex);
                }
                else
                {
                    wordIndex++;
                }
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
