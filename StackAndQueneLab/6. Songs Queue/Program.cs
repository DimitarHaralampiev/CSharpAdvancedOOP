using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrSong = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Queue<string> queue = new Queue<string>(arrSong);

            while (queue.Count > 0)
            {
                string command = Console.ReadLine();

                //string[] cmd = command.Split();

                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command == "Show")
                {
                    Console.WriteLine(String.Join(", ", queue));
                }
                else
                {
                    int index = command.IndexOf(' ');
                    string str = command.Substring(index + 1);

                    if (!queue.Contains(str))
                    {
                        queue.Enqueue(str);
                    }
                    else
                    {
                        Console.WriteLine($"{str} is already contained!");
                    }
                }
            }


            Console.WriteLine("No more songs!");

        }
    }
}
