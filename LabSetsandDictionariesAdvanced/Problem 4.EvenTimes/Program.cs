using System;
using System.Collections.Generic;
using System.Net;

namespace Problem_4.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> dict = new Dictionary<int, int>();
            FillDict(dict, n);
            Print(dict);
        }

        static Dictionary<int, int> FillDict(Dictionary<int, int> numbers, int line)
        {
            for (int i = 0; i < line; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }

                numbers[number]++;
            }

            return numbers;
        }

        static void Print(Dictionary<int, int> numbers)
        {
            int num = 0;
            foreach (var item in numbers)
            {
                if (item.Value % 2 == 0)
                {
                    num = item.Key;
                }
            }

            Console.WriteLine(num);
        }
    }
}
