using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2.SetsofElements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            FillSet(firstSet, secondSet);

            foreach (var item in firstSet)
            {
                foreach (var item1 in secondSet)
                {
                    if (item == item1)
                    {
                        Console.Write(item + " ");
                    }
                }               
            }
        }

        private static HashSet<int> FillSet(HashSet<int> firstSet, HashSet<int> secondSet)
        {
            int[] nm = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            HashSet<int> total = new HashSet<int>();

            for (int i = 0; i < nm[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }
            for (int i = 0; i < nm[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }
            
            return total;
        }
    }
}
