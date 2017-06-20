namespace Cards
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public class Cards
    {
        public static void Main()
        {
            var pattern = @"([1]?[0-9JQKA])([SHDC])";
            var text = Console.ReadLine();

            var regex = new Regex(pattern);
            var cards = regex.Matches(text);

            var resultCards = new List<string>();

            foreach (Match card in cards)
            {
                int power = 0;
                if (int.TryParse(card.Groups[1].Value, out power))
                {
                    if (power < 2 || power > 10) 
                    {
                        continue;
                    }
                }
                resultCards.Add(card.Value);
            }
            Console.WriteLine(string.Join(", ",resultCards));
        }
    }
}
