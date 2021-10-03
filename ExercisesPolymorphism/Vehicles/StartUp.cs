using System;
using System.Linq;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine()
                .Split()
                .ToArray();

            string[] truckInfo = Console.ReadLine()
                .Split()
                .ToArray();

            string[] busInfo = Console.ReadLine()
                .Split()
                .ToArray();

            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            Bus bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {

                string[] command = Console.ReadLine().Split();
                string cmd = command[0];
                string type = command[1];
                double amount = double.Parse(command[2]);

                if (cmd == "Drive")
                {
                    if (type == "Car")
                    {
                        CanDrive(car, amount);
                    }
                    else if (type == "Truck")
                    {
                        CanDrive(truck, amount);
                    }
                    else
                    {
                        bus.IsEmpty = false;
                        CanDrive(bus, amount);
                    }
                }
                else if (cmd == "Refuel")
                {
                    try
                    {
                        if (type == "Car")
                        {
                            car.Refuel(amount);
                        }
                        else if (type == "Truck")
                        {
                            truck.Refuel(amount);
                        }
                        else
                        {
                            bus.Refuel(amount);
                        }
                    }
                    catch (InvalidOperationException io)
                    {

                        Console.WriteLine(io.Message);
                    }
                    
                }
                else
                {
                    bus.IsEmpty = true;
                    CanDrive(bus, amount);
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }

        public static void CanDrive(Vehicle vehicle, double distance)
        {
            bool canDrive = vehicle.CanDrive(distance);

            string result = canDrive ? $"{vehicle.GetType().Name} travelled {distance} km"
                : $"{vehicle.GetType().Name} needs refueling";

            Console.WriteLine(result);
        }
    }
}
