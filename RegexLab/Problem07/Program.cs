using System;
using System.Text;

namespace Problem07
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

                if (command[0] == "TakeOdd")
                {
                    for (int i = 1; i < text.Length; i+=2)
                    {
                        stringBuilder.Append(text[i]);
                    }

                    text = stringBuilder.ToString();
                    Console.WriteLine(text);
                }
                else if(command[0] == "Cut")
                {
                    int index = int.Parse(command[1]);
                    int lenght = int.Parse(command[2]);
                    text = text.Remove(index, lenght);

                    Console.WriteLine(text);
                }
                else if(command[0] == "Substitute")
                {
                    //text = stringBuilder.ToString();

                    if (text.Contains(command[1]))
                    {
                        text = text.Replace(command[1], command[2]);
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
