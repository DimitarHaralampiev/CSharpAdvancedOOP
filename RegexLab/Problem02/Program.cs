using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@">>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d+)!(?<quontity>\d+)");

            List<string> list = new List<string>();

            double totalSum = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Purchase")
                {
                    break;
                }

                Match match = regex.Match(line);

                if (!match.Success)
                {
                    continue;
                }

                string furnitureName = match.Groups["name"].Value;
                double price = double.Parse(match.Groups["price"].Value);
                int quantity = int.Parse(match.Groups["quontity"].Value);

                totalSum += price * quantity;

                list.Add(furnitureName);
            }

            Console.WriteLine("Bought furniture:");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {totalSum:F2}");
        }
    }
}
