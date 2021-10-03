using System;
using System.Linq;

namespace _3._PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int[] arrNumber = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < arrNumber.Length; j++)
                {
                    if (i == j)
                    {
                        sum += arrNumber[j];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
