using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < number; i++)
            {
                var dress = Console.ReadLine().Split(" -> ").ToArray();
                var dresVidove = dress[1].Split(',');
                if (!dict.ContainsKey(dress[0]))
                {
                    dict.Add(dress[0], new Dictionary<string, int>());
                }

                foreach (var item in dresVidove)
                {
                  if (!dict[dress[0]].ContainsKey(item))
                  {
                     dict[dress[0]].Add(item, 0);
                  }
                     dict[dress[0]][item]++;
                }





               

            }
            var command = Console.ReadLine().Split();

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var item2 in item.Value)
                {
                    if (item.Key == command[0] && item2.Key == command[1])
                    {
                        Console.WriteLine($"* {item2.Key} - {item2.Value} (found!)");

                    }
                    else
                    {

                        Console.WriteLine($"* {item2.Key} - {item2.Value}");
                    }

                }
            }


        }
    }
}
