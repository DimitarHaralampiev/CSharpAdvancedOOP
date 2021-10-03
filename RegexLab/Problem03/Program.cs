using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyValuePairs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToDictionary(x => x, x => 0);

            Regex regexName = new Regex(@"[A-Za-z]+");
            Regex digitRexeg = new Regex(@"\d");

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of race")
                {
                    break;
                }

                MatchCollection matches = regexName.Matches(line);
                MatchCollection digitMatches = digitRexeg.Matches(line);

                string name = GetName(matches);
                int sum = GetSum(digitMatches);

                if (!keyValuePairs.ContainsKey(name))
                {
                    continue;
                }

                keyValuePairs[name] += sum;
            }

            string[] orderByDesc = keyValuePairs
                .OrderByDescending(x => x.Value)
                .Take(3)
                .Select(x => x.Key)
                .ToArray();

            Console.WriteLine($"1st place: {orderByDesc[0]}");
            Console.WriteLine($"2nd place: {orderByDesc[1]}");
            Console.WriteLine($"3rd place: {orderByDesc[2]}");
        }

        private static int GetSum(MatchCollection digitMatches)
        {
            int sum = 0;

            foreach (Match match in digitMatches)
            {
                sum += int.Parse(match.Value);
            }

            return sum;
        }

        private static string GetName(MatchCollection matches)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (Match match in matches)
            {
                stringBuilder.Append(match.Value);
            }

            return stringBuilder.ToString();
        }
    }
}
