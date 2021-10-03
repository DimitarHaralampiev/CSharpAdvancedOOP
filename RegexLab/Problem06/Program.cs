using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(:{2}|\*{2})(?<emojiName>[A-Z][a-z]{2,})\1";
            string digitPattern = @"\d";

            string text = Console.ReadLine();

            List<string> list = new List<string>();

            long digitNumberSum = 1;
            int charToIntSum = 0;
            int count = 0;

            MatchCollection matches = Regex.Matches(text, pattern);
            MatchCollection matches1 = Regex.Matches(text, digitPattern);

            foreach (Match match in matches1)
            {
                digitNumberSum *= int.Parse(match.Value);
            }

            foreach (Match match in matches)
            {
                string name = match.Groups["emojiName"].Value;
                count++;
                charToIntSum = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    char current = name[i];
                    charToIntSum += current;
                }

                if (digitNumberSum < charToIntSum)
                {
                    list.Add(match.Value);
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine($"Cool threshold: {digitNumberSum}");
            Console.WriteLine($"{count} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join("\n", list));
        }
    }
}
