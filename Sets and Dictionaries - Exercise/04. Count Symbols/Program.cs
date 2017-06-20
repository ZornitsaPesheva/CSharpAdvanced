using System;
using System.Collections.Generic;

namespace _04.Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();
           
            for (int i = 0; i < text.Length; i++)
            {
                if (!dict.ContainsKey(text[i]))
                {
                    dict.Add(text[i], 1);
                }
                else
                {
                    dict[text[i]]++;
                }
                
            }

            foreach (var symbol in dict)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");

            }

        }
    }
}
