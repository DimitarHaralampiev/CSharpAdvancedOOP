using System;
using System.Linq;

namespace _4._SymbolinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                char[] arrChar = Console.ReadLine()
                    .ToCharArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = arrChar[j];
                }
            }

            char ch = char.Parse(Console.ReadLine());

            bool IsSymbol = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == ch)
                    {
                        Console.WriteLine($"({i}, {j})");
                        IsSymbol = true;
                    }
                }

            }

            if (!IsSymbol)
            {
                Console.WriteLine($"{ch} does not occur in the matrix");
            }
        }
    }
}
