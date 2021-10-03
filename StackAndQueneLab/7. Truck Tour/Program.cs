using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] petrolAndDistance = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                queue.Enqueue(petrolAndDistance);
            }

            int index = 0;

            while (true)
            {
                int totalFuel = 0;

                foreach (int[] petrolPump in queue)
                {
                    int petrolAmount = petrolPump[0];
                    int distance = petrolPump[1];

                    totalFuel += petrolAmount - distance;

                    if (totalFuel < 0)
                    {
                        queue.Enqueue(queue.Dequeue());
                        index++;
                        break;
                    }
                }

                if (totalFuel >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(index);
        }
    }
}
