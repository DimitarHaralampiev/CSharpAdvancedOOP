using System;
using System.Text;

namespace Problem30
{
    class Program
    {
        static void Main(string[] args)
        {
            double count = double.Parse(Console.ReadLine());
            int paper = int.Parse(Console.ReadLine());

            double totalCount = count * count * 6;
            double sum = 0;

            for (int i = 1; i <= paper; i++)
            {
                double len = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    sum += (len * width) * 0.75;
                    continue;
                }

                if (i % 5 != 0)
                {
                    sum += len * width;
                }          
            }

            if (sum < totalCount)
            {
                Console.WriteLine("You are out of paper!");
                Console.WriteLine($"{100 - (sum / totalCount * 100):f2}% of the box is not covered.");
            }
            else if(sum >= totalCount)
            {
                Console.WriteLine("You've covered the gift box!");
                Console.WriteLine($"{100 - (totalCount / sum * 100):f2}% wrap paper left.");
            }
        }
    }
}
