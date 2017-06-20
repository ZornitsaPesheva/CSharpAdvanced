using System;
using System.Collections.Generic;

namespace _06.A_Miner_s_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();
            string resource = " ";

            while (!resource.Equals("stop"))
            {
                resource = Console.ReadLine();
                if (!resource.Equals("stop"))
                {
                    var quantity = int.Parse(Console.ReadLine());
                    if (!resources.ContainsKey(resource))
                    {
                        resources.Add(resource, quantity);
                    }
                    else
                    {
                        resources[resource] += quantity;
                    }
                }
            }
            foreach (var res in resources)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
