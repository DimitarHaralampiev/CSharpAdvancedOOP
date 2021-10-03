using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double INCREASEBYSUMMERCONSUMPTION = 1.6;

        public Truck(double fuelQuantity, double fuelConsuption, double tankCapacity)
            : base(fuelQuantity, fuelConsuption, tankCapacity)
        {
        }

        public override double FuelConsuption => base.FuelConsuption + INCREASEBYSUMMERCONSUMPTION;

        public override bool CanDrive(double distance)
        {
            return base.CanDrive(distance);
        }

        public override void Refuel(double amount)
        {
            if (amount > this.TankCapacity)
            {
                base.Refuel(amount);
            }
            base.Refuel(amount * 0.95);
        }
    }
}
