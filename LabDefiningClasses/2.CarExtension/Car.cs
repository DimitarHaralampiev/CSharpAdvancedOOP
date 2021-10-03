using System;
using System.Collections.Generic;
using System.Text;

namespace _2.CarExtension
{
    public class Car
    {
        private string make;

        private string model;

        private int year;

        private double fuelQuantity;

        private double fuelConsumption;

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }

        public void Drive(double distance)
        {
            bool fuelQuantitys = (this.fuelQuantity - (distance * this.fuelConsumption)) > 0;

            if (fuelQuantitys)
            {
                double result = this.fuelConsumption * distance;
                this.FuelQuantity -= result;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmi()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelConsumption:F2}";
        }
    }
}
