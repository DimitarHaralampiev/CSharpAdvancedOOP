using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Person
{
    public class Child : Person
    {

        public Child(string name, int age)
            : base(name, age)
        {

        }

        public override int Age 
        {
            get { return this.Age; }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Children is invalid age");
                }

                this.Age = value;
            }
        }
    }
}
