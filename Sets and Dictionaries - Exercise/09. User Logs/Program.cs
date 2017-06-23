using System;
using System.Collections.Generic;

namespace _09.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<string, Dictionary<string, int>> dict = 
                new SortedDictionary<string, Dictionary<string, int>>();
            
            while (input != "end")
            {
                string[] param = input.Split(' ');

                string ip = (param[0].Split('='))[1];
                string user = (param[2].Split('='))[1];

                if (!dict.ContainsKey(user))
                {
                    Dictionary<string, int> ipsDict = new Dictionary<string, int>();
                    ipsDict.Add(ip, 1);
                    dict.Add(user, ipsDict);
                }
                else if (!dict[user].ContainsKey(ip))
                {
                    dict[user].Add(ip, 1);
                }

                else
                {
                    dict[user][ip]++;
                }


                input = Console.ReadLine();
            }

            foreach (var usr in dict)
            {
                Console.WriteLine(usr.Key + ":");
                
                HashSet<string> result = new HashSet<string>();

                foreach (var uip in usr.Value)
                {
                    result.Add(uip.Key + " => " + uip.Value);
                }

                Console.WriteLine(string.Join(", ", result) + ".");
            }
        }
    }
}
