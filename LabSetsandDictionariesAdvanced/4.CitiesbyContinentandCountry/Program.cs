using System;
using System.Collections.Generic;

namespace _4.CitiesbyContinentandCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continentsAndCoutriesAndCities = 
                new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] arrayCCC = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string continets = arrayCCC[0];
                string coutry = arrayCCC[1];
                string city = arrayCCC[2];

                if (!continentsAndCoutriesAndCities.ContainsKey(continets))
                {
                    continentsAndCoutriesAndCities.Add(continets, new Dictionary<string, List<string>>());
                }

                if (!continentsAndCoutriesAndCities[continets].ContainsKey(coutry))
                {
                    continentsAndCoutriesAndCities[continets].Add(coutry, new List<string>());
                }

                continentsAndCoutriesAndCities[continets][coutry].Add(city);
            }

            foreach (var continents in continentsAndCoutriesAndCities)
            {
                Console.WriteLine($"{continents.Key}:");

                foreach (var coutrys in continents.Value)
                {
                    Console.Write($"{coutrys.Key} -> {string.Join(", ", coutrys.Value)}");
                    Console.WriteLine();
                }
            }
        }
    }
}
