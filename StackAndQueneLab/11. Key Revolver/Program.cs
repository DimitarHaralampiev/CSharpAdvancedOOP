using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bullet = int.Parse(Console.ReadLine());
            int barrel = int.Parse(Console.ReadLine());

            int[] bullets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] locks = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int intelligence = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>(locks);
            Stack<int> stack = new Stack<int>(bullets);

            int count = 0;
            int useBullets = 0;

            while (queue.Count > 0 && stack.Count > 0)
            {
                if (queue.Peek() >= stack.Peek())
                {
                    Console.WriteLine("Bang!");
                    queue.Dequeue();
                    stack.Pop();
                }
                else
                {
                    Console.WriteLine("Ping!");
                    stack.Pop();
                }

                count++;

                if (count == barrel && stack.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    count = 0;
                }

                useBullets++;
            }

            if (stack.Count >= 0 && queue.Count == 0)
            {
                Console.WriteLine($"{stack.Count} bullets left. Earned ${intelligence - (useBullets * bullet)}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queue.Count}");
            }
        }
    }
}
