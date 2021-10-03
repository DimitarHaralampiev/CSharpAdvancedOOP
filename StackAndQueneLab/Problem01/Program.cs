using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem01
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            Stack<string> strs = new Stack<string>();

            for (int i = 0; i < str.Length; i++)
            {
                strs.Push(str[i].ToString());
            }

            while (strs.Count > 0)
            {
                Console.Write($"{strs.Pop()}");
            }
            
        }
    }
}
