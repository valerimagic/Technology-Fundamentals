using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {


            var input = Console.ReadLine();
            var left = new List<char>();
            var rigth = new List<char>();

            while(input != "END")
            {
                

                for (int i = 0; i < input.Length/2; i++)
                {
                    left.Add(input[i]);
                }

                for (int i = input.Length-1; i > input.Length/2; i--)
                {
                    rigth.Add(input[i]);
                }


                //var revers = Reverse(input);
                //for (int i = 0; i < input.Length/2; i++)
                //{
                //    rigth.Add(revers[i]);
                //}



                input = Console.ReadLine();
            }
        }
    }
}
