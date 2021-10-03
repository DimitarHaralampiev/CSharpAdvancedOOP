using System;

namespace _1.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split();
            var isRow = int.Parse(size[0]);
            var isCol = int.Parse(size[1]);
            var garden = new int[isRow, isCol];

            for (int row = 0; row < isRow; row++)
            {
                for (int col = 0; col < isCol; col++)
                {
                    garden[row, col] = 0;
                }
            }

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "Bloom Bloom Plow")
                {
                    break;
                }

                var row = int.Parse(command[0].ToString());
                var col = int.Parse(command[2].ToString());

                if (row < 0 || row > garden.GetLength(0) && col < 0 || col > garden.GetLength(1))
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }

                for (int i = 0; i < garden.GetLength(0); i++)
                {
                    garden[row, i]++;
                }

                for (int i = 0; i < garden.GetLength(1); i++)
                {
                    garden[i, col]++;
                }

                garden[row, col]--;
            }

            for (int i = 0; i < isRow; i++)
            {
                for (int j = 0; j < isCol; j++)
                {
                    Console.Write(garden[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
