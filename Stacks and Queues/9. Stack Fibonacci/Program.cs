using System;
using System.Collections.Generic;

namespace _9.Stack_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            long nthNumber = long.Parse(Console.ReadLine());
            Stack<long> stack = new Stack<long>();
            stack.Push(1);
            stack.Push(1);

            if (nthNumber == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 3; i <= nthNumber; i++)
                {
                    long second = stack.Pop();
                    long first = stack.Peek();
                    stack.Push(second);
                    stack.Push(first + second);
                }
                Console.WriteLine(stack.Peek());
            }
            
        }
    }
}
