using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var trainers = new List<Trainer>();

            while (true)
            {
                var tokens = Console.ReadLine();

                if (tokens == "Tournament")
                {
                    break;
                }

                var info = tokens.Split();

                var trainerName = info[0];
                var pokemonName = info[1];
                var stat = info[2];
                var health = int.Parse(info[3]);

                if (!trainers.Any(x => x.Name == trainerName))
                {
                    trainers.Add(new Trainer(trainerName));
                }

                var currentTrainer = trainers.Find(x => x.Name == trainerName);
                currentTrainer.Pokemons.Add(new Pokemon(pokemonName, stat, health));
            }

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(x => x.Element == command))
                    {
                        trainer.NumberofBadges++;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Pokemons.Count; i++)
                        {
                            trainer.Pokemons[i].Health -= 10;

                            if (trainer.Pokemons[i].Health <= 0)
                            {
                                trainer.Pokemons.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.NumberofBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberofBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
