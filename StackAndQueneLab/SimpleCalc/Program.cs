using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            Stack<string> stack = new Stack<string>(str); 

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                char op = char.Parse(stack.Pop());
                int second = int.Parse(stack.Pop());

                if (op == '+')
                {
                    stack.Push((first + second).ToString());
                }
                else if(op == '-')
                {
                    stack.Push((first - second).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
