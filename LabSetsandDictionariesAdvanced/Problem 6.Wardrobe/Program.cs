using System;
using System.Collections.Generic;

namespace Problem_6.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe 
                = new Dictionary<string, Dictionary<string, int>>();
            FillDictionary(wardrobe, n);

            string[] clothesToFind = Console.ReadLine()
                .Split();
            string color = clothesToFind[0];
            string cloth = clothesToFind[1];
            PrintToResult(wardrobe, color, cloth);
        }

        private static void PrintToResult(Dictionary<string, Dictionary<string, int>> wordrobe, string color, string cloth)
        {
            foreach (var kvp in wordrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var item in kvp.Value)
                {
                    if (color == kvp.Key && cloth == item.Key)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                        continue;
                    }
                    Console.WriteLine($"* {item.Key} - {item.Value}");
                }
            }
        }

        static Dictionary<string, Dictionary<string, int>> FillDictionary(Dictionary<string, Dictionary<string, int>> wordrobe, int line)
        {
            for (int i = 0; i < line; i++)
            {
                string[] colorAndClothes = Console.ReadLine()
                    .Split(" -> ");

                string color = colorAndClothes[0];
                string[] clothes = colorAndClothes[1].Split(",");
                //string cloth = clothes[0];

                if (!wordrobe.ContainsKey(color))
                {
                    wordrobe.Add(color, new Dictionary<string, int>());
                }

                for (int cloth = 0; cloth < clothes.Length; cloth++)
                {
                    if (!wordrobe[color].ContainsKey(clothes[cloth]))
                    {
                        wordrobe[color].Add(clothes[cloth], 0);
                    }

                    wordrobe[color][clothes[cloth]]++;
                }
            }

            return wordrobe;
        }
    }
}
