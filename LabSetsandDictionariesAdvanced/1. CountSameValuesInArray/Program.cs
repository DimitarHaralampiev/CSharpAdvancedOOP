using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayCounts = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> dict = new Dictionary<double, int>();

            foreach (var counts in arrayCounts)
            {
                if (dict.ContainsKey(counts))
                {
                    dict[counts]++;
                }
                else
                {
                    dict.Add(counts, 1);
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
