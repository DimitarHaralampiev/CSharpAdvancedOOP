using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
         
            List<BaseHero> baseHero = new List<BaseHero>();

            while (baseHero.Count != number)
            {
                try
                {
                    string name = Console.ReadLine();
                    string type = Console.ReadLine();

                    if (type == "Paladin")
                    {
                        baseHero.Add(new Paladin(name));
                    }
                    else if (type == "Druid")
                    {
                        baseHero.Add(new Druid(name));
                    }
                    else if (type == "Rogue")
                    {
                        baseHero.Add(new Rogue(name));
                    }
                    else if (type == "Warrior")
                    {
                        baseHero.Add(new Warrior(name));
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine("Invalid hero!");
                }

            }

            int boss = int.Parse(Console.ReadLine());

            foreach (var item in baseHero)
            {
                Console.WriteLine(item.CastAbility());
            }

            int heroPower = baseHero
                .Sum(x => x.Power);

            if (boss <= heroPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
