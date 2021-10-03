using System;

namespace Problem23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());

            int max = 0;
            double maxBonus = 0;

            for (int i = 0; i < n; i++)
            {
                int students = int.Parse(Console.ReadLine());

                if (students > max)
                {
                    max = students;
                }

                double totalBonus = (double)students / lectures * (5 + bonus);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                }

                totalBonus = 0;
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {max} lectures.");
        }
    }
}
