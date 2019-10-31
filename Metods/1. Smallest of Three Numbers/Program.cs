using System;
using System.Linq;

namespace _1._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            for (int i = 0; i < 3; i++)
            {
            num[i] = int.Parse(Console.ReadLine());

            }
            int smallNumber = SmallerNumber(num);
            Console.WriteLine(smallNumber);
        }

        static int SmallerNumber(int[] numbers)
        {
           
            int result = numbers.Min();
            return result;
           

        }
    }
}
