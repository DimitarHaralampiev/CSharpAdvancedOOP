using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem31
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(", ")
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                string[] command = line.Split(", ");

                if (command[0] == "Add")
                {
                    string name = command[1];

                    if (list.Contains(name))
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                    else
                    {
                        Console.WriteLine("Card successfully added");
                        list.Add(name);
                    }
                }
                else if(command[0] == "Remove")
                {
                    string name = command[1];

                    if (list.Contains(name))
                    {
                        Console.WriteLine("Card successfully removed");
                        list.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                else if(command[0] == "Remove At")
                {
                    int index = int.Parse(command[1]);

                    if (list.Count >= index && index >= 0)
                    {
                        list.RemoveAt(index);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if(command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string name = command[2];

                    if (list.Count >= index && index >= 0)
                    {
                        if (list.Contains(name))
                        {
                            Console.WriteLine("Card is already added");
                        }
                        else
                        {
                            list.Insert(index, name);
                            Console.WriteLine("Card successfully added");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }

            Console.WriteLine($"{string.Join(", ", list)}");
        }
    }
}
