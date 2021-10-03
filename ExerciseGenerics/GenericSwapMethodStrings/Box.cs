using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
{
    public class Box<T>
    {
        public Box(T element)
        {
            this.Element = element;
        }

        public Box(List<T> elements)
        {
            this.Elements = elements;
        }

        public T Element { get; set; }

        public List<T> Elements { get; set; }

        public void Swap(List<T> element, int indexOne, int indexTwo)
        {
            T firstElement = element[indexOne];
            element[indexOne] = element[indexTwo];
            element[indexTwo] = firstElement;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Elements)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
