using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    public class BasicQueueOperations
    {
        public static void Main()
        {
            var commands =
                Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var numbers =
                Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var queue = new Queue<int>();

            var numbersToEnqueue = commands[0];

            for (int i = 0; i < numbersToEnqueue; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            var numbersToDequeue = commands[1];

            for (int i = 0; i < numbersToDequeue; i++)
            {
                queue.Reverse();
                queue.Dequeue();
            }

            var isContained = commands[2];

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(isContained))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
