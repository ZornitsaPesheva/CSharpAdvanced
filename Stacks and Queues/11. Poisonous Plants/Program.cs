﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Poisonous_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            int plantsNumber = int.Parse(Console.ReadLine());

            var plants = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var daysPlansDie = new int[plantsNumber];

            Stack<int> previousPlants = new Stack<int>();

           previousPlants.Push(0);

            for (int i = 1; i < plantsNumber; i++)
            {

                int lastDay = 0;
                while (previousPlants.Count > 0 &&
                    plants[previousPlants.Peek()] >= plants[i])
                {
                    lastDay = Math.Max(lastDay, daysPlansDie[previousPlants.Pop()]);

                }
                if (previousPlants.Count > 0)
                {
                    daysPlansDie[i] = lastDay + 1;
                }
                previousPlants.Push(i);
            }

            Console.WriteLine(daysPlansDie.Max());
        }
    }
}
