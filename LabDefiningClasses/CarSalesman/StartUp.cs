using System;
using System.Collections.Generic;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var numbersOfEngine = int.Parse(Console.ReadLine());
            var engine = new List<Engine>();

            for (int i = 0; i < numbersOfEngine; i++)
            {
                var engines = Console.ReadLine()
                    .Split();

                engine.Add(CreateEngine(engines));
            }

            var numbersOfCar = int.Parse(Console.ReadLine());
            var car = new List<Car>();

            for (int i = 0; i < numbersOfCar; i++)
            {
                var cars = Console.ReadLine()
                    .Split();

                car.Add(CreateCar(cars, engine));
            }

            foreach (var item in car)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static Car CreateCar(string[] cars, List<Engine> engine)
        {
            var carModel = cars[0];
            var engineModel = cars[1];
            var engines = engine.Find(e => e.Model == engineModel);

            var car = new Car(carModel, engines);

            if (cars.Length > 2)
            {

                var isDigit = int.TryParse(cars[2], out int weight);
                if (isDigit)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = cars[2];
                }

                if (cars.Length > 3)
                {
                    car.Color = cars[3];
                }
            }

            return car;
        }

        private static Engine CreateEngine(string[] engines)
        {
            var engineModel = engines[0];
            var enginePower = engines[1];

            var engine = new Engine(engineModel, int.Parse(enginePower));

            if (engines.Length > 2)
            {
                var isDigit = int.TryParse(engines[2], out int displasement);

                if (isDigit)
                {
                    engine.Displacement = displasement;
                }
                else
                {
                    engine.Efficiency = engines[2];
                }
            }

            if (engines.Length > 3)
            {
                engine.Efficiency = engines[3];
            }

            return engine;
        }
    }
}
