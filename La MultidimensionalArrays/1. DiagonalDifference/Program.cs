using System;
using System.Linq;

namespace _1._DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] arr = new int[size, size];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int[] number = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = number[j];
                }
            }


            int sumPrimary = 0;
            int sumSecond = 0;

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                sumPrimary += arr[row, row];
                sumSecond += arr[row, size - row - 1];
            }

            Console.WriteLine(Math.Abs(sumPrimary - sumSecond));
        }
    }
}
