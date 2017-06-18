﻿using System;
using System.Collections.Generic;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var reservations = new SortedSet<string>();

            var input = Console.ReadLine();

            while (input != "PARTY")
            {
                reservations.Add(input);
                input = Console.ReadLine();
            }

            while (input != "END")
            {
                reservations.Remove(input);
                input = Console.ReadLine();
            }

            Console.WriteLine(reservations.Count);
            foreach (var reservation in reservations)
            {
                Console.WriteLine(reservation);
            }
        }
    }
}
