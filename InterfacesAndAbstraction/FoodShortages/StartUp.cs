using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortages
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

           var buyers = new List<IBuyer>();

            for (int i = 0; i < n; i++)
            {
                var info = Console.ReadLine()
                    .Split();

                var name = info[0];
                var age = int.Parse(info[1]);

                if (info.Length == 4)
                {
                    var personId = info[2];
                    var personBirthday = info[3];

                    buyers.Add(new Citizen(name, age, personId, personBirthday));
                }
                else if (info.Length == 3)
                {
                    var group = info[2];

                    buyers.Add(new Rebel(name, age, group));
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                var buyer = buyers.FirstOrDefault(x => x.Name == command);

                if (buyer != null)
                {
                    buyer.BuyFood();
                }
            }

            Console.WriteLine(buyers.Sum(x => x.Food));
        }
    }
}
