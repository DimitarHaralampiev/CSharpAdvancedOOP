using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Problem20
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(=|\/{1})(?<name>[A-Z][A-za-z]{2,})\1");
            string text = Console.ReadLine();

            int sum = 0;

            List<string> list = new List<string>();

            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                list.Add(match.Groups["name"].Value);

                var lenght = match.Groups["name"].Value.Length;

                sum += lenght;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", list)}");
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}
