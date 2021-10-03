using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            while (true)
            {
                string command = Console.ReadLine().ToLower();

                if (command == "end")
                {
                    break;
                }

                string[] cmd = command.Split(' ');

                //for (int i = 0; i < stack.Count; i++)
                //{
                if (cmd[0] == "add")
                {
                    stack.Push(int.Parse(cmd[1]));
                    stack.Push(int.Parse(cmd[2]));
                }
                else if (cmd[0] == "remove")
                {
                    int count = int.Parse(cmd[1]);

                    if (stack.Count < count)
                    {
                        break;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        stack.Pop();
                    }
                }
                //}

            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
