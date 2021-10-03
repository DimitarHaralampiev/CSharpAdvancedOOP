using System;

namespace Problem14
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Generate")
                {
                    break;
                }

                string[] command = line.Split(">>>");
                string cmd = command[0];

                if (cmd == "Contains")
                {
                    string substring = command[1];

                    if (text.Contains(substring))
                    {
                        Console.WriteLine($"{text} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if(cmd == "Flip")
                {
                    string str = command[1];
                    int startIndex = int.Parse(command[2]);
                    int endIndex = int.Parse(command[3]);

                    string substring = text.Substring(startIndex, endIndex - startIndex);

                    if (str == "Upper")
                    {
                        text = text.Replace(substring, substring.ToUpper());
                    }
                    else
                    {
                        text = text.Replace(substring, substring.ToLower());
                    }

                    Console.WriteLine(text);
                }
                else if(cmd == "Slice")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    text = text.Remove(startIndex, endIndex - startIndex);

                    Console.WriteLine(text);
                }
            }

            Console.WriteLine($"Your activation key is: {text}");
        }
    }
}
