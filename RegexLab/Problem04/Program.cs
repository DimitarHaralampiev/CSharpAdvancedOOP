using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^[^|$%.]*%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>\d+\.?\d+)[^|$%.]*\$$");

            double totalSum = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of shift")
                {
                    break;
                }

                Match match = regex.Match(line);

                if (!match.Success)
                {
                    continue;
                }

                string name = match.Groups["name"].Value;
                string product = match.Groups["product"].Value;
                int quantity = int.Parse(match.Groups["quantity"].Value);
                double price = double.Parse(match.Groups["price"].Value);

                //keyValuePairs.Add(name, product);

                double sum = price * quantity;

                Console.WriteLine($"{name}: {product} - {sum:F2}");

                totalSum += sum;
            }

            Console.WriteLine($"Total income: {totalSum:F2}");
        }
    }
}
