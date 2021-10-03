using System;
using System.Linq;

namespace _5._SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] arrNum = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = arrNum[j];
                }
            }

            int maxSum = int.MinValue;
            int maxRow = 0;
            int manCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int newSquareSum = matrix[row, col] +
                                       matrix[row + 1, col] +
                                       matrix[row, col + 1] +
                                       matrix[row + 1, col + 1];

                    if (newSquareSum > maxSum)
                    {
                        maxSum = newSquareSum;
                        maxRow = row;
                        manCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxRow, manCol]} {matrix[maxRow, manCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, manCol]} {matrix[maxRow + 1, manCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
