using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {

        private double pressure;

        private int tireAge;

        public Tire(double pressure, int tireAge)
        {
            this.Pressure = pressure;
            this.TireAge = tireAge;
        }

        public double Pressure { get; set; }

        public int TireAge { get; set; }
    }
}
