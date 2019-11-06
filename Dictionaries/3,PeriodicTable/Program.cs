using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var set = new SortedSet<string>();

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split();
                foreach (var item in input)
                {
                    set.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", set));
        }
    }
}
