using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double INCREASEBYFUELBUS = 1.4;

        public Bus(double fuelQuantity, double fuelConsuption, double tankCapacity) 
            : base(fuelQuantity, fuelConsuption, tankCapacity)
        {
        }

        public bool IsEmpty { get; set; }

        public override double FuelConsuption => !this.IsEmpty ? base.FuelConsuption + INCREASEBYFUELBUS 
            : base.FuelConsuption;

        public override bool CanDrive(double distance)
        {
            return base.CanDrive(distance);
        }

        public override void Refuel(double amount)
        {
            base.Refuel(amount);
        }
    }
}
