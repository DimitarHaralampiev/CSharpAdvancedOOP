using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int capacyti = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;

            Stack<int> stack = new Stack<int>(clothes);

            while (stack.Count > 0)
            {
                sum += stack.Peek();

                if (sum > capacyti)
                {
                    count++;
                    sum = stack.Pop();
                }
                else
                {
                    stack.Pop();
                }
            }

            Console.WriteLine(count + 1);
        }
    }
}
