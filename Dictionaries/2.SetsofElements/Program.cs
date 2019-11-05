using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.SetsofElements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();

            var num = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < num[0]; i++)
            {
                var input = int.Parse(Console.ReadLine());
                first.Add(input);
            }
            for (int i = 0; i < num[1]; i++)
            {
                var input = int.Parse(Console.ReadLine());
                second.Add(input);
            }
            if (first.Count > second.Count)
            {

                foreach (var item in second)
                {
                    if (first.Contains(item))
                    {
                        Console.Write(item + " ");
                    }

                }
                Console.WriteLine();
            }
            else
            {
                foreach (var item in first)
                {
                    if (second.Contains(item))
                    {
                        Console.Write(item + " ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}

