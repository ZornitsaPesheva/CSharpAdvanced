using System;
using System.Collections.Generic;

namespace Count_Same_Values_In_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputTokens = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var dikt = new SortedDictionary<double, int>();

            foreach (var token in inputTokens)
            {
                double reminder;
                if (token.Contains(","))
                {
                    reminder = double.Parse(token.Replace(",", "."));
                }
                else
                {
                    reminder = double.Parse(token);
                }



                if (!dikt.ContainsKey(reminder))
                {
                    dikt.Add(reminder, 1);
                }
                else
                {
                    dikt[reminder]++;
                }
            }

            foreach (var pair in dikt)
            {
                if (pair.Key.ToString().Contains("."))
                {
                    var reminder = pair.Key.ToString().Replace(",", ",");
                    Console.WriteLine($"{reminder} - {pair.Value} times");
                }
                else
                {
                    Console.WriteLine($"{pair.Key} - {pair.Value} times");
                }

            }
        }
    }
}
