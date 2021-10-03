using System;

namespace Problem29
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int count = 0;

            bool isEnergy = true;

            while (true)
            {

                string distance = Console.ReadLine();

                if (distance == "End of battle")
                {
                    break;
                }

                int dist = int.Parse(distance);

                if (dist > energy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {energy} energy");
                    return;
                }

                count++;

                energy -= dist;

                if (count % 3 == 0)
                {
                    energy += count;
                }
            }

            Console.WriteLine($"Won battles: {count}. Energy left: {energy}");
        }
    }
}
