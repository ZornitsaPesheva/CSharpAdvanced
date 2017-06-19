using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Sets_Of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sets = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int n = sets[0];
            int m = sets[1];

            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                set1.Add(num);
            }

            for (int i = 1; i <= m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (set1.Contains(num))
                {
                    set2.Add(num);
                }
                
            }

            Console.WriteLine(string.Join(" ", set2));
        }
    }
}
