using System;
using System.Linq;

namespace _3.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        { 
            Func<string, bool> strAndBool = text => text[0] == text.ToUpper()[0];

            var word = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(strAndBool)
                .ToArray();

            foreach (var item in word)
            {
                Console.WriteLine(item);
            }
        }
    }
}
