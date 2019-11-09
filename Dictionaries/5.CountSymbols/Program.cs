using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToArray();

            var dict = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {

           
                if (!dict.ContainsKey(input[i]))
                {
                    dict.Add(input[i], 0);
                }
                dict[input[i]]++;
            }

            foreach (var item in dict)
            {

                Console.WriteLine($"{item.Key}: {item.Value} time/s");
                
            }
        }
    }
}
