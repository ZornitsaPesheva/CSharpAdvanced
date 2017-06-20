using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            string entry = " ";
            entry = Console.ReadLine();

            while (!entry.Equals("stop"))
            {             
                string[] phone = entry.Split('-').ToArray();

                if (phone.Length > 1)
                {
                    phonebook[phone[0]] = phone[1];
                }
                else if (entry != "search")
                {
                    if (phonebook.ContainsKey(entry))
                    {
                        Console.WriteLine($"{entry} -> {phonebook[entry]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {entry} does not exist.");
                    }
                }

                entry = Console.ReadLine();
            }
        }
    }
}
