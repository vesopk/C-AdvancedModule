using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HandsOfCards
{
    public class HandsOfCards
    {
        public static void Main()
        {
            var playersAndScores = new Dictionary<string, int>();
            var playerUniqueCards = new Dictionary<string, List<string>>();

            var command = Console.ReadLine();

            var aceScore = 14;
            var kingScore = 13;
            var queenScore = 12;
            var jackScore = 11;

            var spadesRatio = 4;
            var heartsRatio = 3;
            var diamondsRatio = 2;
            var clubsRatio = 1;

            while (true)
            {
                if (command == "JOKER")
                {
                    break;
                }

                var commandParams = command.Split(':').ToList();
                var player = commandParams[0];
                var cards = commandParams[1];

                var regexPattern = @"(?<fullMatch>(?<cardPower>(?:[2-9]|10)|[JKQA])(?<cardType>[SDHC]))";
                var regex = new Regex(regexPattern);

                var matches = regex.Matches(cards);
                var score = 0;


                foreach (Match match in matches)
                {
                    var wholeCard = match.Groups["fullMatch"].Value;
                    var cardPower = match.Groups["cardPower"].Value;
                    var cardType = match.Groups["cardType"].Value;

                    if (!playerUniqueCards.ContainsKey(player))
                    {
                        playerUniqueCards[player] = new List<string>();
                    }

                    if (cardType == "S" && !playerUniqueCards[player].Contains(wholeCard))
                    {
                        if (cardPower == "A")
                        {
                            score += aceScore * spadesRatio;
                            playerUniqueCards[player].Add(wholeCard);
                        }
                        else if (cardPower == "K")
                        {
                            score += kingScore * spadesRatio;
                            playerUniqueCards[player].Add(wholeCard);
                        }
                        else if (cardPower == "Q")
                        {
                            score += queenScore * spadesRatio;
                            playerUniqueCards[player].Add(wholeCard);
                        }
                        else if (cardPower == "J")
                        {
                            score += jackScore * spadesRatio;
                            playerUniqueCards[player].Add(wholeCard);
                        }
                        else
                        {
                            var cardTypeToInt = int.Parse(cardPower);
                            score += cardTypeToInt * spadesRatio;
                            playerUniqueCards[player].Add(wholeCard);
                        }
                    }
                    else if (cardType == "H" && !playerUniqueCards[player].Contains(wholeCard))
                    {
                        if (cardPower == "A")
                        {
                            score += aceScore * heartsRatio;
                            playerUniqueCards[player].Add(wholeCard);
                        }
                        else if (cardPower == "K")
                        {
                            score += kingScore * heartsRatio;
                            playerUniqueCards[player].Add(wholeCard);
                        }
                        else if (cardPower == "Q")
                        {
                            score += queenScore * heartsRatio;
                            playerUniqueCards[player].Add(wholeCard);
                        }
                        else if (cardPower == "J")
                        {
                            score += jackScore * heartsRatio;
                            playerUniqueCards[player].Add(wholeCard);
                        }
                        else
                        {
                            var cardTypeToInt = int.Parse(cardPower);
                            score += cardTypeToInt * heartsRatio;
                            playerUniqueCards[player].Add(wholeCard);
                        }
                    }
                    else if (cardType == "D" && !playerUniqueCards[player].Contains(wholeCard))
                    {
                        if (cardPower == "A")
                        {
                            score += aceScore * diamondsRatio;
                            playerUniqueCards[player].Add(wholeCard);
                        }
                        else if (cardPower == "K")
                        {
                            score += kingScore * diamondsRatio;
                            playerUniqueCards[player].Add(wholeCard);
                        }
                        else if (cardPower == "Q")
                        {
                            score += queenScore * diamondsRatio;
                            playerUniqueCards[player].Add(wholeCard);
                        }
                        else if (cardPower == "J")
                        {
                            score += jackScore * diamondsRatio;
                            playerUniqueCards[player].Add(wholeCard);
                        }
                        else
                        {
                            var cardTypeToInt = int.Parse(cardPower);
                            score += cardTypeToInt * diamondsRatio;
                            playerUniqueCards[player].Add(wholeCard);
                        }
                    }
                    else if (cardType == "C" && !playerUniqueCards[player].Contains(wholeCard))
                    {
                        if (cardPower == "A")
                        {
                            score += aceScore * clubsRatio;
                            playerUniqueCards[player].Add(wholeCard);
                        }
                        else if (cardPower == "K")
                        {
                            score += kingScore * clubsRatio;
                            playerUniqueCards[player].Add(wholeCard);
                        }
                        else if (cardPower == "Q")
                        {
                            score += queenScore * clubsRatio;
                            playerUniqueCards[player].Add(wholeCard);
                        }
                        else if (cardPower == "J")
                        {
                            score += jackScore * clubsRatio;
                            playerUniqueCards[player].Add(wholeCard);
                        }
                        else
                        {
                            var cardTypeToInt = int.Parse(cardPower);
                            score += cardTypeToInt * clubsRatio;
                            playerUniqueCards[player].Add(wholeCard);
                        }

                    }
                }
                if (!playersAndScores.ContainsKey(player))
                {
                    playersAndScores[player] = score;
                }
                else
                {
                    playersAndScores[player] += score;
                }
                command = Console.ReadLine();
            }
            foreach (var player in playersAndScores)
            {
                Console.WriteLine($"{player.Key}: {player.Value}");
            }
        }
    }
}
