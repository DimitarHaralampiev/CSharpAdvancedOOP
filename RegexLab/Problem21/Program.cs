using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Problem21
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string txt = text;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Complete")
                {
                    break;
                }

                string[] command = line.Split();
                string cmd = command[0];

                if (cmd == "Make")
                {
                    if (command[1] == "Upper")
                    {
                        text = text.ToUpper();
                        Console.WriteLine(text);
                    }
                    else
                    {
                        text = text.ToLower();
                        Console.WriteLine(text);
                    }
                    txt = text;
                }
                else if(cmd == "GetDomain")
                {
                    int count = int.Parse(command[1]);

                    text = txt.Substring(txt.Length - count, count);

                    Console.WriteLine(text);
                }
                else if(cmd == "GetUsername")
                {

                    StringBuilder stringBuilder = new StringBuilder();

                    if (!txt.Contains("@"))
                    {
                        Console.WriteLine($"The email {txt} doesn't contain the @ symbol.");
                    }
                    else
                    {
                        foreach (char ch in txt)
                        {
                            if (ch == '@')
                            {
                                break;
                            }

                            stringBuilder.Append(ch);
                        }
                        text = stringBuilder.ToString();
                        Console.WriteLine(text);
                    }
                                     
                }
                else if(cmd == "Encrypt")
                {
                    for (int i = 0; i < txt.Length; i++)
                    {
                        Console.Write((int)txt[i] + " ");
                    }
                    Console.WriteLine();
                }
                else if(cmd == "Replace")
                {
                    char oldChar = char.Parse(command[1]);
                    text = txt.Replace(oldChar, '-');

                    Console.WriteLine(text);
                }
            }
        }
    }
}
