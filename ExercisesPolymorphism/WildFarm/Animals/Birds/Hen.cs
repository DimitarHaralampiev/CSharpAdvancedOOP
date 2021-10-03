using System;
using WildFarm.Foods;

namespace WildFarm.Animals.Birds
{
    public class Hen : Bird
    {
        private const double INCREASING_WEIGHT = 0.35;

        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override void ProduceSound(Food food)
        {
            Console.WriteLine("Cluck");

            this.FoodEaten += food.Quantity;
            this.Weight += (INCREASING_WEIGHT * food.Quantity);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
