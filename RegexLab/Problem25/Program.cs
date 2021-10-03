using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem25
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(", ")
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Craft!")
                {
                    break;
                }

                string[] cmd = line.Split(" - ");
                string command = cmd[0];

                if (command == "Collect")
                {
                    string item = cmd[1];

                    if (!list.Contains(item))
                    {
                        list.Add(item);
                    }
                }
                else if(command == "Drop")
                {
                    string item = cmd[1];

                    if (list.Contains(item))
                    {
                        list.Remove(item);
                    }
                }
                else if(command == "Combine Items")
                {
                    //string[] cmd1 = line.Split(":");
                    string[] oldItem = cmd[1].Split(":");
                    string newItem = oldItem[0];
                    string oldItems = oldItem[1];

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == newItem)
                        {
                            list.Insert(i + 1, oldItems);
                        }
                    }
                }
                else if(command == "Renew")
                {
                    string item = cmd[1];

                    if (list.Contains(item))
                    {
                        list.Remove(item);
                        list.Add(item);
                    }
                }
            }

            Console.WriteLine($"{string.Join(", ", list)}");
        }
    }
}
