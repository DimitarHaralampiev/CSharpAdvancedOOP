using System;
using System.Text;

namespace Problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Done")
                {
                    break;
                }

                string[] command = line.Split();
                string cmd = command[0];

                if (cmd == "TakeOdd")
                {
                    for (int i = 1; i < text.Length; i+=2)
                    {
                        stringBuilder.Append(text[i]);
                    }

                    text = stringBuilder.ToString();
                    Console.WriteLine(text);
                }
                else if(cmd == "Cut")
                {
                    int index = int.Parse(command[1]);
                    int lenght = int.Parse(command[2]);

                    text = text.Remove(index, lenght);
                    Console.WriteLine(text);
                }
                else if (cmd == "Substitute")
                {
                    string subs = command[1];
                    string substring = command[2];

                    if (text.Contains(subs))
                    {
                        text = text.Replace(subs, substring);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }

            Console.WriteLine($"Your password is: {text}");
        }
    }
}
