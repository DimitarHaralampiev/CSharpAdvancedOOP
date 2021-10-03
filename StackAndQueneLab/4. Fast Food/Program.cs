using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int query = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;

            Queue<int> queue = new Queue<int>(numbers);

            Console.WriteLine(numbers.Max());

            while (queue.Count > 0)
            {
                int firstNum = queue.Peek();
                sum += firstNum;
                //queue.Enqueue(numbers[i]);

                if (sum <= query)
                {
                    queue.Dequeue();
                }
                else
                {
                    Console.Write($"Orders left: {string.Join(' ', queue)}");
                    return;
                }
            }

            Console.WriteLine("Orders complete");
        }
    }
}
