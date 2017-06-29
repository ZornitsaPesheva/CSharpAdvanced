using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfLogs = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, int>> users = 
                new SortedDictionary<string, SortedDictionary<string, int>>();
            
            for (int i = 1; i <= numberOfLogs; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ');

                string user = input[1];
                string ip = input[0];
                int duration = int.Parse(input[2]);

                if (!users.ContainsKey(user))
                {
                    SortedDictionary<string, int> ipDictionary = 
                        new SortedDictionary<string, int>();
                    ipDictionary.Add(ip, duration);

                    users.Add(user, ipDictionary);
                }
                else
                {
                    if (!users[user].ContainsKey(ip))
                    {
                        users[user].Add(ip, duration);
                    }
                    else
                    {
                        users[user][ip] += duration;
                    }
                }
            }

            foreach (var u in users)
            {
                Console.WriteLine($"{u.Key}: {u.Value.Values.Sum()} [" +
                                  $"{String.Join(", ", u.Value.Keys)}]");
            }
        }
    }
}
