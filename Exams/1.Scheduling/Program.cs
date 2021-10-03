using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            var threads = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var kill = int.Parse(Console.ReadLine());

            var stackTask = new Stack<int>(tasks);
            var queueThread = new Queue<int>(threads);

            var task = 0;
            var thread = 0;

            while (stackTask.Count > 0 && queueThread.Count > 0)
            {
                if (stackTask.Peek() == kill)
                {
                    thread = queueThread.Peek();
                    task = stackTask.Pop();
                    break;
                }

                if (queueThread.Peek() >= stackTask.Peek())
                {
                    queueThread.Dequeue();
                    stackTask.Pop();
                }
                else
                {
                    queueThread.Dequeue();
                }
            }

            Console.WriteLine($"Thread with value {thread} killed task {task}");
            Console.Write(string.Join(" ", queueThread));
        }
    }
}
