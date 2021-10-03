using System;
using System.Collections.Generic;
using System.Text;

namespace _5.SpecialCars
{
    public class Tire
    {
        private int year;

        private double pressure;

        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public double Pressure
        {
            get { return this.pressure; }
            set { this.pressure = value; }
        }

        public List<double> GetTire(string[] tires)
        {
            List<double> listYear = new List<double>();

            for (int i = 0; i < tires.Length; i+=2)
            {
                listYear.Add(int.Parse(tires[i]));
            }

            return listYear;
        }

        public List<double> GetTire(string[] tires)
        {
            List<double> listPressure = new List<double>();

            for (int i = 0; i < tires.Length; i += 2)
            {
                listPressure.Add(int.Parse(tires[i]));
            }

            return listPressure;
        }
    }
}
