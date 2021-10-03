using System;
using System.Linq;

namespace _2._2X2SquaresinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = ReadMatrix(size[0], size[1]);

            int count = 0;

            for (int row = 0; row <= matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - 2; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1]
                        && matrix[row + 1, col] == matrix[row + 1, col + 1]
                        && matrix[row, col] == matrix[row + 1, col])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        private static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] letter = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = letter[col];
                }
            }

            return matrix;
        }
    }
}
