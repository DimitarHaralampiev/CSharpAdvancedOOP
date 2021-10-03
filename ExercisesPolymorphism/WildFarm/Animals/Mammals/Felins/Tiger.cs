using System;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals.Felins
{
    public class Tiger : Feline
    {
        private const double INCREASING_WEIGHT = 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void ProduceSound(Food food)
        {
            Console.WriteLine("ROAR!!!");

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
