using System;
using System.Linq;

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            string array = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Generate")
                {
                    break;
                }

                string[] command = line.Split(">>>");
                string commandName = command[0];

                if (commandName == "Slice")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    array = array.Remove(startIndex, (endIndex - startIndex));
                 
                    Console.WriteLine(array);
                }
                else if (commandName == "Flip")
                {
                    int startIndex = int.Parse(command[2]);
                    int endIndex = int.Parse(command[3]);

                    if (command[1] == "Upper")
                    {
                        string text1 = array.Substring(startIndex, (endIndex - startIndex));
                        string text = array.Substring(startIndex, (endIndex - startIndex)).ToUpper();

                        array = array.Replace(text1, text);

                        Console.WriteLine(array);
                    }
                    else
                    {
                        string text1 = array.Substring(startIndex, (endIndex - startIndex));
                        string text = array.Substring(startIndex, (endIndex - startIndex)).ToLower();

                        array = array.Replace(text1, text);

                        Console.WriteLine(array);
                    }
                }
                else if (commandName == "Contains")
                {
                    string substring = command[1];

                    if (array.Contains(substring))
                    {
                        Console.WriteLine($"{array} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
            }

            Console.WriteLine($"Your activation key is: {array}");
        }
    }
}
