using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            var bufer = new List<int>();

            for (int i = 15; i <= number; i++)
            {
                var str = i.ToString();
                int num = int.Parse(str);

                for (int j = 0; j < str.Length; j++)
                {
                    int currentDigit = num % 10;
                    bufer.Add(currentDigit);
                    num /= 10;
                }

                int count = 0;
                if(bufer.Sum() % 8  == 0)
                {
                    for (int k = 0; k < bufer.Count; k++)
                    {
                        if(bufer[k] % 2 != 0)
                        {
                            count++;
                        }
                    }
                    if(count != 0)
                    {
                       Console.WriteLine(i);
                    }
                }
                bufer.Clear();
                count = 0;
            }


        }
    }
}
