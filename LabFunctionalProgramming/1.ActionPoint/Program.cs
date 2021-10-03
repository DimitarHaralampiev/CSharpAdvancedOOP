using System;
using System.Linq;

namespace _1.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> action = str => Console.WriteLine(str);

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(str => Console.WriteLine(str));
        }
    }
}
