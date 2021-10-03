using System;
using System.Collections.Generic;
using System.Linq;

namespace _11PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new List<string>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries));

            var filter = new List<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Print")
                {
                    break;
                }

                string[] cmd = command.Split(";");

                if (cmd[0] == "Add filter")
                {
                    filter.Add(cmd[1] + " " + cmd[2]);
                }
                else if (cmd[0] == "Remove filter")
                {
                    filter.Remove(cmd[1] + " " + cmd[2]);
                }
            }

            foreach (var filters in filter)
            {
                var commands = filters.Split(' ');

                if (commands[0] == "Starts")
                {
                    name = name.Where(p => !p.StartsWith(commands[2])).ToList();
                }
                else if (commands[0] == "Ends")
                {
                    name = name.Where(p => !p.EndsWith(commands[2])).ToList();
                }
                else if (commands[0] == "Length")
                {
                    name = name.Where(p => p.Length != int.Parse(commands[1])).ToList();
                }
                else if (commands[0] == "Contains")
                {
                    name = name.Where(p => !p.Contains(commands[1])).ToList();
                }
            }

            if (name.Any())
            {
                Console.WriteLine(string.Join(" ", name));
            }
        }
    }
}
