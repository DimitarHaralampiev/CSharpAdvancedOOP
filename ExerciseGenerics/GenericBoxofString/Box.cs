using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxofString
{
    public class Box<T>
    {

        public Box(T element)
        {
            this.Element = element;
        }

        public T Element { get; }

        public override string ToString()
        {
            return $"{this.Element.GetType()}: {this.Element}";
        }
    }
}
