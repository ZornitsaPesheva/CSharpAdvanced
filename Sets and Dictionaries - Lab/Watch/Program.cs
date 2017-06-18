using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watch
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var list = new List<string>();
            var set = new HashSet<string>();

            Console.WriteLine("List:");
            for (int i = 0; i < 1000000; i++)
            {
                list.Add(i.ToString());
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            Console.WriteLine(watch.ElapsedTicks);

            watch = Stopwatch.StartNew();
            list.Contains("888888");
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            Console.WriteLine(watch.ElapsedTicks);

            Console.WriteLine();
            Console.WriteLine("Set:");
            watch = Stopwatch.StartNew();
            for (int i = 0; i < 1000000; i++)
            {
                set.Add(i.ToString());
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            Console.WriteLine(watch.ElapsedTicks);
            
            watch = Stopwatch.StartNew();
            set.Contains("888888");
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            Console.WriteLine(watch.ElapsedTicks);
        }
    }
}
