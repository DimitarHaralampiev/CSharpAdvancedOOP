using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<string> list = new List<string>();

            Regex regex = new Regex(@"((::)|(\*\*))(?<emoji>[A-Z][a-z]{2,})\1");
            Regex digitRegex = new Regex(@"\d");

            MatchCollection matchesString = regex.Matches(text);
            MatchCollection matchesDigit = digitRegex.Matches(text);

            long totalSum = 1;

            foreach (Match match in matchesDigit)
            {
                totalSum *= long.Parse(match.Value);
            }

            Console.WriteLine($"Cool threshold: {totalSum}");
            Console.WriteLine($"{matchesString.Count} emojis found in the text. The cool ones are:");

            foreach (Match match1 in matchesString)
            {
                string name = match1.Groups["emoji"].Value;
                long charSum = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    char current = name[i];
                    charSum += current;
                }

                if (charSum > totalSum)
                {
                    Console.WriteLine(match1.Value);
                }
            }

            
        }
    }
}
