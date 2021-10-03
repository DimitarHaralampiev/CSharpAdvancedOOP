using System;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cars = new Car[n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                string model = tokens[0];
                double fuelAmount = double.Parse(tokens[1]);
                double cons = double.Parse(tokens[2]);

                cars[i] = new Car(model, fuelAmount, cons);
            }

            while (true)
            {
                var tokens = Console.ReadLine();
                var command = tokens.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "End")
                {
                    break;
                }

                string model = command[1];
                double distance = double.Parse(command[2]);

                cars
                    .Where(c => c.Model == model)
                    .ToList()
                    .ForEach(c => c.Moving(distance));
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
