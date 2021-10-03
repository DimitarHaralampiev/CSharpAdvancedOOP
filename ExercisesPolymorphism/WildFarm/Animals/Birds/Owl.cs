using System;
using WildFarm.Foods;

namespace WildFarm.Animals.Birds
{
    public class Owl : Bird
    {
        private const double INCREASING_WEIGHT = 0.25;

        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override void ProduceSound(Food food)
        {
            Console.WriteLine("Hoot Hoot");

            if ((food is Meat) == false)
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
