using System;
using System.Collections.Generic;

namespace _01.Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var set = new HashSet<string>();
            for (int i = 1; i <= number; i++)
            {
                string name = Console.ReadLine();
                set.Add(name);
            }

            foreach (var name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}
