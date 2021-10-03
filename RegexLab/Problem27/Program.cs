using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem27
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine()
                .Split("!")
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Go Shopping!")
                {
                    break;
                }

                string[] command = line.Split();
                string cmd = command[0];

                if (cmd == "Urgent")
                {
                    string item = command[1];

                    if (!(products.Contains(item)))
                    {
                        products.Insert(0, item);
                    }
                }
                else if(cmd == "Unnecessary")
                {
                    string item = command[1];

                    if (products.Contains(item))
                    {
                        products.Remove(item);
                    }
                }
                else if(cmd == "Correct")
                {
                    string oldItem = command[1];
                    string newItem = command[2];

                    for (int i = 0; i < products.Count; i++)
                    {
                        if (products[i] == oldItem)
                        {
                            products.Remove(oldItem);
                            products.Insert(i, newItem);
                        }
                    }
                }
                else if(cmd == "Rearrange")
                {
                    string item = command[1];

                    if (products.Contains(item))
                    {
                        products.Remove(item);
                        products.Add(item);
                    }
                }
            }

            Console.WriteLine($"{string.Join(", ", products)}");
        }
    }
}
