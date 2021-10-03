using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> name = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string nm = Console.ReadLine();
                name.Add(nm);
            }

            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }
    }
}
