using System;
using System.Linq;

namespace _3._MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeRowCol = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int[,] matrix = ReadMatrix(sizeRowCol[0], sizeRowCol[1]);

            int maxSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int firstSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2];
                    int secondSum = matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2];
                    int thirdSum = matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    int sum = firstSum + secondSum + thirdSum;

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = bestRow; row <= bestRow + 2; row++)
            {
                for (int col = bestCol; col <= bestCol + 2; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            return matrix;
        }
    }
}
