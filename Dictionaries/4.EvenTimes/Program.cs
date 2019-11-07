using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var dict = new Dictionary<int, int>();

            for (int i = 0; i < num; i++)
            {
                var input = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(input))
                {
                    dict.Add(input, 1);
                }
                else
                {
                    dict[input]++;
                }
            }

            Console.WriteLine(dict.First(x => x.Value % 2 == 0).Key);
        }
    }
}
