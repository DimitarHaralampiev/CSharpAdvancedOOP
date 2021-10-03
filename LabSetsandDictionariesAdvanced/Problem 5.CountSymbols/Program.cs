using System;
using System.Collections.Generic;

namespace Problem_5.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] ch = Console.ReadLine().ToCharArray();
            SortedDictionary<char, int> sorted = new SortedDictionary<char, int>();
            FillSortedDict(sorted, ch);
            PrintSortedDict(sorted);
        }

        static SortedDictionary<char, int> FillSortedDict(SortedDictionary<char, int> sorted, char[] ch)
        {
            for (int i = 0; i < ch.Length; i++)
            {
                char on = ch[i];

                if (!sorted.ContainsKey(on))
                {
                    sorted.Add(on, 0);
                }

                sorted[on]++;
            }
            return sorted;
        }

        static void PrintSortedDict(SortedDictionary<char, int> sorted)
        {
            foreach (var kvp in sorted)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
