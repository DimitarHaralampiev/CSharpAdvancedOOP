using System;

namespace Problem09
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Travel")
                {
                    break;
                }

                string[] command = line.Split(":");

                string cmd = command[0];

                if (cmd == "Add Stop")
                {
                    int index = int.Parse(command[1]);
                    string str = command[2];

                    if (index <= text.Length && index >= 0)
                    {
                        text = text.Insert(index, str);
                    }

                    Console.WriteLine(text);
                }
                else if (cmd == "Remove Stop")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex >= 0 && startIndex < text.Length && endIndex >= 0 && endIndex <= text.Length - 1 && startIndex <= endIndex)
                    {
                        text = text.Remove(startIndex, (endIndex - startIndex + 1));
                    }

                    Console.WriteLine(text);
                }
                else
                {
                    string oldString = command[1];
                    string newString = command[2];

                    if (text.Contains(oldString))
                    {
                        text = text.Replace(oldString, newString);
                    }

                    Console.WriteLine(text);
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {text}");
        }
    }
}
