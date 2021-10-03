using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._01.Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            var basket = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var freshnessLevel = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queueBasket = new Queue<int>(basket);
            Stack<int> stackLevel = new Stack<int>(freshnessLevel);

            int countDippingSauce = 0;
            int countGreenSalad = 0;
            int countChocolateCake = 0;
            int countLobster = 0;

            bool isDippingSauce = false;
            bool isGreenSalad = false;
            bool isChocolateCake = false;
            bool isLobster = false;

            Dictionary<string, int> kvp = new Dictionary<string, int>();

            while (queueBasket.Count > 0 || stackLevel.Count > 0)
            {
                if (queueBasket.Peek() == 0)
                {
                    queueBasket.Dequeue();
                    continue;
                }

                int result = queueBasket.Peek() * stackLevel.Peek();

                if (result == 150)
                {
                    queueBasket.Dequeue();
                    stackLevel.Pop();
                    countDippingSauce++;
                    isDippingSauce = true;
                }
                else if (result == 250)
                {
                    queueBasket.Dequeue();
                    stackLevel.Pop();
                    countGreenSalad++;
                    isGreenSalad = true;
                }
                else if (result == 300)
                {
                    queueBasket.Dequeue();
                    stackLevel.Pop();
                    countChocolateCake++;
                    isChocolateCake = true;
                }
                else if (result == 400)
                {
                    queueBasket.Dequeue();
                    stackLevel.Pop();
                    countLobster++;
                    isLobster = true;
                }
                else
                {
                    stackLevel.Pop();
                    result = queueBasket.Dequeue() + 5;
                    queueBasket.Enqueue(result);
                }
            }

            if (isDippingSauce && isGreenSalad && isChocolateCake && isLobster)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
                kvp.Add("Chocolate cake", countChocolateCake);
                kvp.Add("Dipping sauce", countDippingSauce);
                kvp.Add("Green salad", countGreenSalad);
                kvp.Add("Lobster", countLobster);

                foreach (var item in kvp.OrderBy(x => x.Key))
                {
                    if (item.Value > 0)
                    {
                        Console.WriteLine($"# {item.Key} --> {item.Value}");
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");

                if (isDippingSauce)
                {
                    kvp.Add("Dipping sauce", countDippingSauce);
                }
                else if (isGreenSalad)
                {
                    kvp.Add("Green salad", countGreenSalad);
                }
                else if (isLobster)
                {
                    kvp.Add("Lobster", countLobster);
                }
                else if (isChocolateCake)
                {
                    kvp.Add("Chocolate cake", countChocolateCake);
                }

                if (queueBasket.Count > 0)
                {
                    Console.WriteLine($"Ingredients left: {queueBasket.Sum()}");
                }

                foreach (var item in kvp.OrderBy(x => x.Key))
                {
                    if (item.Value > 0)
                    {
                        Console.WriteLine($"# {item.Key} --> {item.Value}");
                    }

                }
            }
           
        }
    }
}
