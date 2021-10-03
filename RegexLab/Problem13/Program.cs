using System;
using System.Text.RegularExpressions;

namespace Problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"([#|\|])(?<name>[A-Za-z\s]+)\1(?<day>\d{2})\/(?<month>(\d{2}))\/(?<year>(\d{2}))\1(?<calories>(\d){1,5})\1");
            string text = Console.ReadLine();

            int totalSum = 0;
            int count = 0;

            MatchCollection matches = regex.Matches(text);

            foreach (Match match1 in matches)
            {
                totalSum += int.Parse(match1.Groups["calories"].Value);
            }

            Console.WriteLine($"You have food to last you for: {totalSum / 2000} days!");

            foreach (Match match in matches)
            {
                string name = match.Groups["name"].Value;
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;
                int calories = int.Parse(match.Groups["calories"].Value);

                if (match.Success)
                {
                    Console.WriteLine($"Item: {name}, Best before: {day}/{month}/{year}, Nutrition: {calories}");
                }
            }
        }
    }
}
