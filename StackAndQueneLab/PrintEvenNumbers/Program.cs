using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> qu = new Queue<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    qu.Enqueue(numbers[i]);
                }
            }

            //foreach (var item in qu)
            //{
                Console.Write($"{String.Join(", ", qu)}");
            //}

        }
    }
}
