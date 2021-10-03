using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.FindEvensorOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var query = Console.ReadLine();

            Predicate<int> predicate = query == "odd"
                ? new Predicate<int>((number) => number % 2 != 0)
                : new Predicate<int>((number) => number % 2 == 0);

            var result = new List<int>();

            for (int i = array[0]; i <= array[1]; i++)
            {
                if (predicate(i))
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
