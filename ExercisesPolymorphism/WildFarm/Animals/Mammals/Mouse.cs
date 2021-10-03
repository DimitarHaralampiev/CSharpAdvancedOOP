using System;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals
{
    public class Mouse : Mammal
    {
        private const double INCREASING_WEIGHT = 0.10;

        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void ProduceSound(Food food)
        {
            Console.WriteLine("Squeak");

            if (!(food is Vegetable || food is Fruit))
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
                return;
            }

            this.FoodEaten += food.Quantity;
            this.Weight += (INCREASING_WEIGHT * food.Quantity);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
