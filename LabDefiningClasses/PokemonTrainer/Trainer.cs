using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {

        public string Name { get; set; }

        public int NumberofBadges { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public Trainer()
        {

        }

        public Trainer(string name)
        {
            this.Name = name;
            this.NumberofBadges = 0;
            this.Pokemons = new List<Pokemon>();
        }

    }
}
