using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            var liquids = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ingredients = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var queueLiquids = new Queue<int>(liquids);
            var stackIngredients = new Stack<int>(ingredients);

            int bread = 0;
            int cake = 0;
            int pastry = 0;
            int fruitPie = 0;

            bool isBread = false;
            bool isCake = false;
            bool isPastry = false;
            bool isFruitPie = false;

            while (queueLiquids.Count > 0 && stackIngredients.Count > 0)
            {
                int result = stackIngredients.Peek() + queueLiquids.Peek();

                if (result == 25)
                {
                    stackIngredients.Pop();
                    queueLiquids.Dequeue();
                    bread++;
                    isBread = true;
                }
                else if (result == 50)
                {
                    stackIngredients.Pop();
                    queueLiquids.Dequeue();
                    cake++;
                    isCake = true;
                }
                else if (result == 75)
                {
                    stackIngredients.Pop();
                    queueLiquids.Dequeue();
                    pastry++;
                    isPastry = true;
                }
                else if (result == 100)
                {
                    stackIngredients.Pop();
                    queueLiquids.Dequeue();
                    fruitPie++;
                    isFruitPie = true;
                }
                else
                {
                    queueLiquids.Dequeue();
                    int pop = stackIngredients.Pop() + 3;
                    stackIngredients.Push(pop);
                }
            }

            if (isBread && isCake && isPastry && isFruitPie)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (queueLiquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", queueLiquids)}");
            }

            if (stackIngredients.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", stackIngredients)}");
            }

            Console.WriteLine($"Bread: {bread}\nCake: {cake}\nFruit Pie: {fruitPie}\nPastry: {pastry}");
        }
    }
}
