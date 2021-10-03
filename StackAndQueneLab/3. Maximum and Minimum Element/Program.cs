using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {

                int[] arrNum = Console.ReadLine()
                   .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();

                if (arrNum[0] == 1)
                {
                    stack.Push(arrNum[1]);
                }
                else if(arrNum[0] == 2 && stack.Any())
                {
                    stack.Pop();
                }
                else if(arrNum[0] == 3 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max()); 
                }
                else if(arrNum[0] == 4 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }

            //int count = stack.Count();
            //int a = 1;

            //foreach (int value in stack)
            //{
                //Console.Write(value);
                Console.Write(String.Join(", ", stack));
            //}

            //Console.WriteLine();
        }
    }
}
