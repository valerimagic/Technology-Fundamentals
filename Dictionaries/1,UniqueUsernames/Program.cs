using System;
using System.Collections.Generic;

namespace _1_UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                names.Add(input);
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
