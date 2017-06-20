using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emails = new Dictionary<string, string>();
            string entry = " ";
            while (!entry.Equals("stop"))
            {
                entry = Console.ReadLine();
                if (!entry.Equals("stop"))
                {
                    var name = entry;
                    emails[name] = Console.ReadLine();
                }
            }
            var edited = emails
                .Where(e => DomainOK(e));
            foreach (var e in edited)
            {
                Console.WriteLine($"{e.Key} -> {e.Value}");
            }
        }

        private static bool DomainOK(KeyValuePair<string, string> e)
        {
            string[] args = e.Value.Split('.');
            string last = args[args.Length - 1];
            return last != "us" && last != "uk";
        }
    }
}
