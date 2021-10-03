using System;
using System.Collections.Generic;
using System.Text;

namespace _3.CarConstructors
{
    public class Car
    {
        private string make;

        private string model;

        private int year;

        private double fuelQuantity;

        private double fuelConsumption;

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.fuelQuantity = 200;
            this.fuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            :this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsuption)
            :this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsuption;
        }

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
            return $"Make: {this.Make}" +
                $"\nModel: {this.Model}" +
                $"\nYear: {this.Year}" +
                $"\nConsuption: {this.FuelConsumption}" +
                $"\nFuel: {this.FuelQuantity:F2}";
        }
    }
}
