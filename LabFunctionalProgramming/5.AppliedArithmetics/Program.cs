using System;
using System.Linq;

namespace _5.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();


            Func<int, int> add = x => ++x;
            Func<int, int> subtract = x => --x;
            Func<int, int> multiply = x => x * 2;
              

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                if (command == "add")
                {
                    numbers = numbers.Select(x => add(x)).ToArray();
                }
                else if(command == "subtract")
                {
                    numbers = numbers.Select(x => subtract(x)).ToArray();
                }
                else if(command == "multiply")
                {
                    numbers = numbers.Select(x => multiply(x)).ToArray();
                }
                else if(command == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }
            }
        }
    }
}
