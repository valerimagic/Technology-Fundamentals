using System;

namespace _2._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            Vowel(input);
        }

        static void Vowel(string word)
        {
            int count = 0;

            foreach (var item in word)
            {
                if(item == 'a' || item == 'e' || item =='o' || item== 'u' 
                    || item == 'i' || item == 'y')
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
