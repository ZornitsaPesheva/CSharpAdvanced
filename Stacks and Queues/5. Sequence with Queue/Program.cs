using System;
using System.Collections.Generic;

namespace _5.Sequence_with_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Queue<long> queue = new Queue<long>();
            Queue<long> queue1 = new Queue<long>();

            queue.Enqueue(n);
            long s1 = queue.Peek();

            while (queue.Count < 50)
            {
                queue.Enqueue(s1 + 1);
                queue1.Enqueue(s1 + 1);
                long sx = queue1.Dequeue();
                if (queue.Count < 50)
                {
                    queue.Enqueue(2 * s1 + 1);
                    queue1.Enqueue(2 * s1 + 1);
                }               

                if (queue.Count < 50)
                {
                    queue.Enqueue(s1 + 2);
                    queue1.Enqueue(s1 + 2);
                }                
                
                s1 = sx;
            }

            Console.Write(string.Join(" ", queue));

        }
    }
}
