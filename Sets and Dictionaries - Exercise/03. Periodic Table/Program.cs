using System;
using System.Collections.Generic;

namespace _03.Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            SortedSet<string> set = new SortedSet<string>();

            for (int i = 1; i <= number; i++)
            {
                string[] compounds = Console.ReadLine()
                    .Split(' ');

                for (int j = 0; j < compounds.Length; j++)
                {
                    set.Add(compounds[j]);
                }
            }

            Console.WriteLine(string.Join(" ", set));
        }
    }
}
