using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] nameAndAge = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = nameAndAge[0];
                int age = int.Parse(nameAndAge[1]);

                var person = new Person(name, age);
                family.AddMember(person);
            }

            HashSet<Person> persons = family.AgeIsMoreThan30();
            Console.WriteLine(string.Join(Environment.NewLine, persons));
        }
    }
}
