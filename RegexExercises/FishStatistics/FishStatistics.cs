namespace FishStatistics
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public class FishStatistics
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = "([>]*)<([(]+)(['-x])>";
            var regex = new Regex(pattern);
            var fishes = regex.Matches(input);
            var resultFishes = new List<Fish>();
            foreach (Match fish in fishes)
            {
                var tailLength = fish.Groups[1].Value.Length;
                var bodyLength = fish.Groups[2].Value.Length;
                var status = "";

                if (fish.Groups[3].Value == "-")
                {
                    status = "Asleep";
                }
                else if (fish.Groups[3].Value == "x")
                {
                    status = "Dead";
                }
                else
                {
                    status = "Awake";
                }
                var currentFish = new Fish()
                {
                    TailLength = tailLength,
                    BodyLength = bodyLength,
                    Status = status
                };
                resultFishes.Add(currentFish);
            }
            if (fishes.Count > 0)
            {
                var i = 0;
                foreach (var fish in resultFishes)
                {
                    Console.WriteLine($"Fish {i + 1}: {fishes[i]}");
                    i++;

                    if (fish.TailLength == 0)
                    {
                        Console.WriteLine($"  Tail type: None");
                    }
                    else if (fish.TailLength == 1)
                    {
                        Console.WriteLine($"  Tail type: Short ({fish.TailLength * 2} cm)");
                    }
                    else if (fish.TailLength > 1 && fish.TailLength <= 5)
                    {
                        Console.WriteLine($"  Tail type: Medium ({fish.TailLength * 2} cm)");
                    }
                    else if (fish.TailLength > 5)
                    {
                        Console.WriteLine($"  Tail type: Long ({fish.TailLength * 2} cm)");
                    }

                    if (fish.BodyLength > 5 && fish.BodyLength <= 10)
                    {
                        Console.WriteLine($"  Body type: Medium ({fish.BodyLength * 2} cm)");
                    }
                    else if (fish.BodyLength > 10)
                    {
                        Console.WriteLine($"  Body type: Long ({fish.BodyLength * 2} cm)");
                    }
                    else
                    {
                        Console.WriteLine($"  Body type: Short ({fish.BodyLength * 2} cm)");
                    }
                    Console.WriteLine($"  Status: {fish.Status}");
                }
            }
            else
            {
                Console.WriteLine("No fish found.");
            }
        }
    }
}
class Fish
{
    public int TailLength { get; set; }
    public int BodyLength { get; set; }
    public string Status { get; set; }
}