using System;

namespace Problem26
{
    class Program
    {
        static void Main(string[] args)
        {
            int efficiency1 = int.Parse(Console.ReadLine());
            int efficiency2 = int.Parse(Console.ReadLine());
            int efficiency3 = int.Parse(Console.ReadLine());

            int peopleCount = int.Parse(Console.ReadLine());

            int totalEfficiency = efficiency1 + efficiency2 + efficiency3;
            //int people = totalEfficiency * 3;

            int count = 0;

            while (peopleCount > 0)
            {
                count++;

                if (count % 4 == 0)
                {
                    continue;
                }

                peopleCount -= totalEfficiency;
            }

            Console.WriteLine($"Time needed: {count}h.");
        }
    }
}
