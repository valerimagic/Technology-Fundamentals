<<<<<<< HEAD
﻿namespace _02.Common_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] firstArr = Console.ReadLine().Split();
            string[] secondArr = Console.ReadLine().Split();

            List<string> comminElements = new List<string>();

            foreach (var str in secondArr)
            {
                if (firstArr.Contains(str))
                {
                    comminElements.Add(str);
                }
            }

            Console.WriteLine(string.Join(" ", comminElements));
        }
    }
=======
﻿namespace _02.Common_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] firstArr = Console.ReadLine().Split();
            string[] secondArr = Console.ReadLine().Split();

            List<string> comminElements = new List<string>();

            foreach (var str in secondArr)
            {
                if (firstArr.Contains(str))
                {
                    comminElements.Add(str);
                }
            }

            Console.WriteLine(string.Join(" ", comminElements));
        }
    }
>>>>>>> 8aeef7617cdd74b6add997ea9bbad5655cb5dd75
}