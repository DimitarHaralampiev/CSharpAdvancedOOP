using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = numbersArray[0];

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {                
                stack.Push(arr[i]);
            }

            for (int i = 0; i < numbersArray[1]; i++)
            {
                stack.Pop();
            }
            if (stack.Count > 0)
            {
                if (stack.Contains(numbersArray[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
