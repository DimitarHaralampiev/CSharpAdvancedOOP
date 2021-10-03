using System;
using System.Collections.Generic;
using System.Linq;

namespace Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if (ch == '(')
                {
                    stack.Push(i.ToString());
                }
                else if(ch == ')')
                {
                    string startIndex = stack.Pop();
                    Console.WriteLine(str.Substring(int.Parse(startIndex), i - int.Parse(startIndex) + 1));
                }
            }
        }
    }
}
