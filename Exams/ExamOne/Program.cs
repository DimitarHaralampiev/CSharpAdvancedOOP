using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamOne
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] hats = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] scarfs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int stack = 0;

            Stack<int> stackHats = new Stack<int>(hats);
            Queue<int> queueScarfs = new Queue<int>(scarfs);

            Queue<int> newQueue = new Queue<int>();

            while (stackHats.Count > 0 || queueScarfs.Count > 0)
            {

                if (stackHats.Peek() == queueScarfs.Peek())
                {
                    stack = stackHats.Pop();
                    stackHats.Push(++stack);
                    queueScarfs.Dequeue();
                }

                if (stackHats.Peek() < queueScarfs.Peek())
                {
                    stackHats.Pop();
                }
                else
                {
                    stack = stackHats.Pop() + queueScarfs.Dequeue();
                    newQueue.Enqueue(stack);
                }
            }

            Console.Write($"The most expensive set is: {newQueue.Max()}\n{string.Join(" ", newQueue)}");
        }
    }
}
