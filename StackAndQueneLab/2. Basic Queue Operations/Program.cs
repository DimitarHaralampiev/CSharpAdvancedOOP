using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = numbersArray[0];

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(arr[i]);
            }

            for (int i = 0; i < numbersArray[1]; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count > 0)
            {
                if (queue.Contains(numbersArray[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
