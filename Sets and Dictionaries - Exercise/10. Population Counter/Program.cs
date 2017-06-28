using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countries =
                new Dictionary<string, Dictionary<string, long>>();
            
            string input = Console.ReadLine();

            while (input != "report")
            {
                string[] data = input.Split('|');
                string city = data[0];
                string country = data[1];
                long population = long.Parse(data[2]);

                if (!countries.ContainsKey(country))
                {
                    Dictionary<string, long> ci = new Dictionary<string, long>();
                    ci.Add(city, population);
                    countries.Add(country, ci);
                }
                else
                {
                    if (!countries[country].ContainsKey(city))
                    {
                        countries[country].Add(city, population);
                    }
                    else
                    {
                        countries[country][city] += population;
                    }
                }

                input = Console.ReadLine();
            }

            Dictionary<string, long> countriesOrdered =
                new Dictionary<string, long>();

            foreach (var c in countries)
            {
                long total = 0;
                foreach (var s in c.Value)
                {
                    total += s.Value;
                }
                countriesOrdered.Add(c.Key, total);
            }

            foreach (var c in countriesOrdered.OrderByDescending(c => c.Value))
            {
                
                Console.Write($"{c.Key} (total population: ");
                
                Console.WriteLine($"{c.Value})");

                foreach (var s in countries[c.Key].OrderByDescending(x => x.Value))
                {

                    Console.WriteLine($"=>{s.Key}: {s.Value}");     
                    
                }

            }
        }
    }
}
