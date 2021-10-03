using System;
using System.Linq;

namespace _4._MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeRowCol = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rows = sizeRowCol[0];
            int cols = sizeRowCol[1];

            string[,] rowCol = ReadMatrix(rows, cols);
            

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split();

                if (command[0] == "END")
                {
                    break;
                }

                if (command[0] == "swap" 
                    && int.Parse(command[1]) < rows 
                    && int.Parse(command[1]) < cols 
                    && command.Length == 5)
                {
                    int first = int.Parse(command[1]);
                    int second = int.Parse(command[2]);
                    int third = int.Parse(command[3]);
                    int four = int.Parse(command[4]);


                    string temp = rowCol[first, second];
                    rowCol[first, second] = rowCol[third, four];
                    rowCol[third, four] = temp;

                    PrintMatrix(rowCol);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        static string[,] ReadMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] numbers = Console.ReadLine()
                    .Split();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            return matrix;
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{string.Join(' ', matrix[row, col])} ");
                }

                Console.WriteLine();
            }
        }
    }
}
