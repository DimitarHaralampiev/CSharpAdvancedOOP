using System;
using System.Collections.Generic;

namespace Traffic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            int count = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                queue.Enqueue(command);

                if (command == "green")
                {
                    for (int i = 0; i < queue.Count; i++)
                    {
                        Console.WriteLine($" {queue.Dequeue()} passed!");
                        count++;
                    }

                    //count = queue.Count;
                }
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
