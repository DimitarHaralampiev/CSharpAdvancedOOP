using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> nameAndGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] student = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = student[0];
                decimal grades = decimal.Parse(student[1]);

                if (nameAndGrades.ContainsKey(name))
                {
                    nameAndGrades[name].Add(grades);
                }
                else
                {
                    nameAndGrades.Add(name, new List<decimal>() 
                    { 
                        grades 
                    });
                }
            }

            foreach (var student in nameAndGrades)
            {
                //Console.WriteLine($"{string.Join(" ", student.Value).Select()} (avg: {student.Value.Average():f2})");

                List<decimal> grade = student.Value;
                decimal average = student.Value.Average();

                Console.Write($"{student.Key} -> ");

                foreach (var item in grade)
                {
                    Console.Write($"{item:f2} ");
                    
                }
                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
