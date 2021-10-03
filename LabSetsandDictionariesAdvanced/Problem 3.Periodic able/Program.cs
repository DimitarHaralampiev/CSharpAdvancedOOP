using System;
using System.Collections.Generic;

namespace Problem_3.Periodic_able
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            SortedSet<string> hs = FillSortedSet(num);

            Console.Write($"{string.Join(" ", hs)}");
        }

        static SortedSet<string> FillSortedSet(int n)
        {
            SortedSet<string> sorted = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine()
                    .Split();

                for (int j = 0; j < arr.Length; j++)
                {
                    sorted.Add(arr[j]);
                }
               
            }

            return sorted;
        }
    }
}
