using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _3._ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops =
                new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string shop = command[0];

                if (shop == "Revision")
                {
                    break;
                }

                string product = command[1];
                double price = double.Parse(command[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }

                shops[shop].Add(product, price);
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
