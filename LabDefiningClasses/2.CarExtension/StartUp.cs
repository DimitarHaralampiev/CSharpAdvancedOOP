using System;

namespace _2.CarExtension
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "BMW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            car.Drive(2000);
            Console.WriteLine(car.WhoAmi());
        }
    }
}
