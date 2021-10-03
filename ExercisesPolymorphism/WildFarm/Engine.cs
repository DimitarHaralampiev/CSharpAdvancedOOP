using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Animals;
using WildFarm.Animals.Birds;
using WildFarm.Animals.Mammals;
using WildFarm.Animals.Mammals.Felins;
using WildFarm.Foods;

namespace WildFarm
{
    public class Engine
    {
        public void Run()
        {
            List<Animal> animals = new List<Animal>();

            AddAnimals(animals);

            foreach (var animal in animals)
            {
                Console.WriteLine(animal + " " + animal.FoodEaten + "]");
            }
        }

        private void AddAnimals(List<Animal> animals)
        {
            Animal animal = null;

            while (true)
            {
                string[] tokens = Console.ReadLine()
                    .Split();

                if (tokens[0] == "End")
                {
                    break;
                }

                string type = tokens[0];
                string name = tokens[1];
                double weight = double.Parse(tokens[2]);

                switch (type)
                {
                    case "Cat":
                        string livingRegion = tokens[3];
                        string breed = tokens[4];
                        animal = new Cat(name, weight, livingRegion, breed);
                        break;
                    case "Tiger":
                        livingRegion = tokens[3];
                        breed = tokens[4];
                        animal = new Tiger(name, weight, livingRegion, breed);
                        break;
                    case "Dog":
                        livingRegion = tokens[3];
                        animal = new Dog(name, weight, livingRegion);
                        break;
                    case "Mouse":
                        livingRegion = tokens[3];
                        animal = new Mouse(name, weight, livingRegion);
                        break;
                    case "Owl":
                        double wingSize = double.Parse(tokens[3]);
                        animal = new Owl(name ,weight, wingSize);
                        break;
                    case "Hen":
                        wingSize = double.Parse(tokens[3]);
                        animal = new Hen(name, weight, wingSize);
                        break;
                    default:
                        break;
                }

                string[] foodInfo = Console.ReadLine()
                    .Split();
                string foodType = foodInfo[0];
                int quantity = int.Parse(foodInfo[1]);

                animal.ProduceSound(TakeFood(foodType, quantity));
                animals.Add(animal);
            }
        }

        private Food TakeFood(string type, int quantity)
        {
            switch (type)
            {
                case "Meat":
                    return new Meat(quantity);
                case "Vegetable":
                    return new Vegetable(quantity);
                case "Seeds":
                    return new Seeds(quantity);
                case "Fruit":
                    return new Fruit(quantity);
            }

            return null;
        }
    }
}
