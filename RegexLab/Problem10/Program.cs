using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(=|\/)(?<location>[A-Z][A-Za-z]{2,})\1";

            string text = Console.ReadLine();

            List<string> list = new List<string>();

            int len = 0;

            MatchCollection matches = Regex.Matches(text, regex);

            foreach (Match match in matches)
            {

                if (match.Success)
                {
                    list.Add(match.Groups["location"].Value);
                }

                len += match.Groups["location"].Value.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", list)}");
            Console.WriteLine($"Travel Points: {len}");
        }
    }
}
