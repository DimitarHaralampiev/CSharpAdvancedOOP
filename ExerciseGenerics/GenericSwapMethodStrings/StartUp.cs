using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                list.Add(input);
            }

            Box<int> box = new Box<int>(list);
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            box.Swap(list, arr[0], arr[1]);
            Console.WriteLine(box);
        }
    }
}
