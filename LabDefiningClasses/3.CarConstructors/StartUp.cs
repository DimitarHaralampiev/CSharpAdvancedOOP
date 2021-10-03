using System;

namespace _3.CarConstructors
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double consuption = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());

            Car carOne = new Car();
            Car carTwo = new Car(make, model, year);
            Car carThird = new Car(make, model, year, fuel, consuption);

            Console.WriteLine(carOne.WhoAmi());
            Console.WriteLine(carTwo.WhoAmi());
            Console.WriteLine(carThird.WhoAmi());
        }
    }
}
