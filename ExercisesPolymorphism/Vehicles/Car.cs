using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double INCREASEBYSUMMER = 0.9;

        public Car(double fuelQuantity, double fuelConsuption, double tankCapacity)
            : base(fuelQuantity, fuelConsuption, tankCapacity)
        {
        }

        public override double FuelConsuption => base.FuelConsuption + INCREASEBYSUMMER;

        public override void Refuel(double amount)
        {
            base.Refuel(amount);
        }

        public override bool CanDrive(double distance)
        {
            return base.CanDrive(distance);
        }
    }
}
