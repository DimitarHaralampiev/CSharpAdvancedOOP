using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementtheCustomListClass
{
    public class CustomList
    {
        private const int initialCapacity = 4;

        private int[] array;

        public CustomList()
        {
            this.array = new int[initialCapacity];
        }

        //public int[] Array { get; set; }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                if (index >= this.Count)
                {
                    throw new ArgumentException();
                }

                return this.array[index];
            }
            set
            {
                if (index >= this.Count)
                {
                    throw new ArgumentException();
                }

                this.array[index] = value;
            }
        }

        public void Add(int element)
        {
            if (this.Count == this.array.Length)
            {
                Resize();
            }

            this.array[this.Count] = element;
            this.Count++;
        }

        private void Resize()
        {
            int[] copy = new int[this.array.Length * 2];

            for (int i = 0; i < array.Length; i++)
            {
                copy[i] = array[i];
            }

            this.array = copy;
        }

        public void Clear()
        {
            this.Count = 0;
            this.array = new int[initialCapacity];
        }

        public int RemoveAt(int index)
        {

            var result = this.array[index];
            if (index > this.Count && index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                for (int i = index + 1; i < this.Count; i--)
                {
                    array[i - 1] = array[i];
                }
            }

            this.Count--;
            return result;
        }

        public bool Contains(int item)
        {
            bool isValid = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item)
                {
                    isValid = true;
                }
            }

            return isValid;
        }

        public void Swap(int firstNumber, int secondNumber)
        {
            int temp = array[firstNumber];
            array[secondNumber] = array[firstNumber];
            array[secondNumber] = temp;
        }
    }
}
