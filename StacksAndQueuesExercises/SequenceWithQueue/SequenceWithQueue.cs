using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceWithQueue
{
    public class SequenceWithQueue
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());

            var magicSequence = new Queue<long>();
            var seqNumbers = new List<long>
            {
                n
            };

            magicSequence.Enqueue(n);
            while (seqNumbers.Count < 50)
            {
                var firstItem = magicSequence.Peek() + 1;
                magicSequence.Enqueue(firstItem);
                var secondItem = (magicSequence.Peek() * 2) + 1;
                magicSequence.Enqueue(secondItem);
                var thirdItem = firstItem + 1;
                magicSequence.Enqueue(thirdItem);

                magicSequence.Dequeue();
                seqNumbers.Add(firstItem);
                seqNumbers.Add(secondItem);
                seqNumbers.Add(thirdItem);
            }

            Console.WriteLine(string.Join(" ", seqNumbers.Take(50)));
        }
    }
}
