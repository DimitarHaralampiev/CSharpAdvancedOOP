using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.ReverseandExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int divide = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            Predicate<int> predicate = x => x % divide != 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (predicate(numbers[i]))
                {
                    list.Add(numbers[i]);
                }
            }
            list.Reverse();
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
