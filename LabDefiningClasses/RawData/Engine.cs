﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Engine
    {

        private int speed;

        private int power;

        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

        public int Speed { get; set; }

        public int Power { get; set; }
    }
}