using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] bottles = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackBottles = new Stack<int>(bottles);
            Queue<int> queueCups = new Queue<int>(cupsCapacity);

            int total = 0;

            while (true)
            {
                if (stackBottles.Count == 0 || queueCups.Count == 0)
                {
                    break;
                }

                int cup = queueCups.Peek();
                int bot = stackBottles.Peek();

                if (bot >= cup)
                {
                    total += bot - cup;
                    stackBottles.Pop();
                    queueCups.Dequeue();
                }
                else if(cup <= 0)
                {
                    queueCups.Dequeue();
                    stackBottles.Pop();
                }
                else if(cup > bot)
                {
                    int reduce = cup - bot;
                    stackBottles.Pop();

                    while (reduce > 0 && stackBottles.Count > 0)
                    {
                        int nextBotles = stackBottles.Peek();

                        if (nextBotles > reduce)
                        {
                            total = total + (nextBotles - reduce);
                            reduce -= nextBotles;
                        }
                        else
                        {
                            reduce -= nextBotles;
                        }

                        stackBottles.Pop();
                    }

                    queueCups.Dequeue();
                }
                
            }

            if (queueCups.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", queueCups)}");
            }
            else if(queueCups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", stackBottles)}");
            }

            Console.WriteLine($"Wasted litters of water: {total}");
        }
    }
}
