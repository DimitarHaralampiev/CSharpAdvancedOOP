using System;
using System.Linq;

namespace _6._JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowSize = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rowSize][];

            for (int i = 0; i < rowSize; i++)
            {
                int[] col = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                matrix[i] = col;
            }

            while (true)
            {
                string line = Console.ReadLine().ToUpper();

                if (line == "END")
                {
                    break;
                }

                string[] tokens = line.Split();
                string command = tokens[0];

                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row < 0 || row >= rowSize || col < 0 || matrix[row].Length <= col)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                switch (command)
                {
                    case "ADD":
                        matrix[row][col] += value;
                        break;
                    case "SUBTRACT":
                        matrix[row][col] -= value;
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < rowSize; i++)
            {
                Console.WriteLine($"{string.Join(" ", matrix[i])}");
            }

        }
    }
}
