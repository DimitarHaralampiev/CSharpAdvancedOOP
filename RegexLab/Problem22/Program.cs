using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem22
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"([\*|\@])(?<name>[A-Z]{1}[a-z]{2,})\1[\:][ ][\[]([A-Za-z]{1})\]\|[\[]([A-Za-z]{1})\]\|[\[]([A-Za-z]{1})\]\|$");

            List<char> list = new List<char>();

            int n = int.Parse(Console.ReadLine());

            string text = string.Empty;

            for (int i = 0; i < n; i++)
            {
                text = Console.ReadLine();

                Match match = regex.Match(text);
                int sumOne = 0;
                int sumTwo = 0;
                int sumThre = 0;

                if (match.Success)
                {
                    var matches = match.Groups["name"].Value;

                    char one = char.Parse(match.Groups[2].Value);
                    char two = char.Parse(match.Groups[3].Value);
                    char three = char.Parse(match.Groups[4].Value);

                    sumOne += one;
                    sumTwo += two;
                    sumThre += three;

                    Console.WriteLine($"{matches}: {sumOne} {sumTwo} {sumThre}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }


        }
    }
}
