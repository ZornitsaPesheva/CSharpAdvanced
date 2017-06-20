using System;
using System.Collections.Generic;

namespace _09.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<string, HashSet<string>> ips = new SortedDictionary<string, HashSet<string>>();
            Dictionary<string, int> msgs = new Dictionary<string, int>();
            
            while (input != "end")
            {
                string[] param = input.Split(' ');

                string ip = (param[0].Split('='))[1];
              //  string message = (param[1].Split('='))[1];
                string user = (param[2].Split('='))[1];

                if (!ips.ContainsKey(user))
                {
                    HashSet<string> ipsList = new HashSet<string>();
                    ipsList.Add(ip);
                    ips.Add(user, ipsList);
                }
                else
                {
                    ips[user].Add(ip);                  
                }

                if (!msgs.ContainsKey(ip))
                {
                    msgs.Add(ip, 1);
                }
                else
                {
                    msgs[ip]++;
                }

                input = Console.ReadLine();
            }

            foreach (var usr in ips)
            {
                Console.WriteLine(usr.Key + ":");

                HashSet<string> result = new HashSet<string>();

                foreach (var uip in usr.Value)
                {
                    result.Add(uip + " => " + msgs[uip]);
                    // Console.WriteLine($"{uip} => {msgs[uip]},");
                }

                Console.WriteLine(string.Join(", ", result) + ".");
            }
        }
    }
}
