using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var car = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var cars = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = cars[0];
                var engine = new Engine(int.Parse(cars[1]), int.Parse(cars[2]));
                var cargo = new Cargo(int.Parse(cars[3]), cars[4]);

                var tire = new Tire[]
                {
                    new Tire(double.Parse(cars[5]), int.Parse(cars[6])),
                    new Tire(double.Parse(cars[7]), int.Parse(cars[8])),
                    new Tire(double.Parse(cars[9]), int.Parse(cars[10])),
                    new Tire(double.Parse(cars[11]), int.Parse(cars[12])),
                };

                car.Add(new Car(model, engine, cargo, tire));
            }

            var type = Console.ReadLine();
            var filtered = new List<Car>();

            if (type == "fragile")
            {
                filtered = car
                    .Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1))
                    .ToList();
            }
            else if(type == "flamable")
            {
                filtered = car
                    .Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250)
                    .ToList();
            }

            foreach (var item in filtered)
            {
                Console.WriteLine(item.Model);
            }
        }
    }
}
