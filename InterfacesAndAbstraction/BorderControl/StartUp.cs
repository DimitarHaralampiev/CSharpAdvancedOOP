using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var all = new List<IBirthday>();

            while (true)
            {
                var command = Console.ReadLine()
                    .Split();

                if (command[0] == "End")
                {
                    break;
                }

                if (command[0] == "Citizen")
                {
                    var name = command[1];
                    var age = int.Parse(command[2]);
                    var personId = command[3];
                    var personBurthday = command[4];

                    all.Add(new Citizen(name, age, personId, personBurthday));
                }
                else if(command[0] == "Pet")
                {
                    var name = command[1];
                    var petBirthday = command[2];

                    all.Add(new Pet(name, petBirthday));
                }
                else if(command[0] == "Robot")
                {
                    var model = command[1];
                    var robotId = command[2];
                }
            }

            var equal = Console.ReadLine();

           all
               .Where(x => x.Birthday.EndsWith(equal))
               .Select(x => x.Birthday)
               .ToList()
               .ForEach(Console.WriteLine);
        }
    }
}
