using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Basic_Stack_Operations
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
            Stack<int> stack = new Stack<int>(numbers);

            for (int i = 1; i <=s; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count() == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                PrintSmallest(stack);
            }
        }

        private static void PrintSmallest(Stack<int> stack)
        {
            int smallest = int.MaxValue;
            while (stack.Count > 0)
            {
                int num = stack.Pop();
                if (num < smallest)
                {
                    smallest = num;
                }
            }
            Console.WriteLine(smallest);
        }
    }
}
