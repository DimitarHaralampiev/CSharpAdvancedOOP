using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortages
{
    public class Rebel : IBuyer
    {
        private string group;

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.group = group;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 5;
        }

    }
}
