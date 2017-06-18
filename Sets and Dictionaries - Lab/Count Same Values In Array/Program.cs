using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_In_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputTokens = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse);

            var dikt = new SortedDictionary<double, int>();

            foreach (var token in inputTokens)
            {

                if (!dikt.ContainsKey(token))
                {
                    dikt.Add(token, 1);
                }
                else
                {
                    dikt[token]++;
                }
            }

            foreach (var pair in dikt)
            {
                 Console.WriteLine($"{pair.Key} - {pair.Value} times");
            }
        }
    }
}
