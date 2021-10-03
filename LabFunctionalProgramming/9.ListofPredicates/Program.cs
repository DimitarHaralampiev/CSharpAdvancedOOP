using System;
using System.Linq;

namespace _9.ListofPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endRange = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int, bool> filter = (allDividers, number) =>
            {
                return allDividers.All(t => number % t == 0);
            };

            var divisibleNumbers = Enumerable.Range(1, endRange).Where(number => filter(dividers, number)).ToArray();
            
            Console.WriteLine(string.Join(" ", divisibleNumbers));
        }
    }
}
