using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var arr = input
                .Trim()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = arr[0];
            int s = arr[1];
            int x = arr[2];

            input = Console.ReadLine();
            var numbers = input.Split(' ').Select(int.Parse);
            Queue<int> queue = new Queue<int>(numbers);

            for (int i = 1; i <= s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count() == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                PrintSmallest(queue);
            }
        }

        private static void PrintSmallest(Queue<int> queue)
        {
            int smallest = int.MaxValue;
            while (queue.Count > 0)
            {
                int num = queue.Dequeue();
                if (num < smallest)
                {
                    smallest = num;
                }
            }
            Console.WriteLine(smallest);
        }
    }
}
