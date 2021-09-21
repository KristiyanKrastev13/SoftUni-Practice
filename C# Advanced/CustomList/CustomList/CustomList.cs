using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
   public class CustomList
    {
        private const int initialCapacity = 2;

        private int[] array;
        public int  Count { get; private set; }


        public CustomList()
        {
            this.array = new int[initialCapacity];
        }

        public int this[int index] {
            get
            {
                if (index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException("Invalid index");
                }
                return this.array[index];
            }
            set
            {
                if (index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.array[index] = value;
            }
        }

        public void Add(int number)
        {
            if(this.Count == this.array.Length)
            {
                this.Resize();
            }
            this.array[this.Count] = number;
            this.Count++;
        }

        private void Resize()
        {
            int[] copy = new int[this.array.Length * 2];
            for (int i = 0; i < this.array.Length; i++)
            {
                copy[i] = this.array[i];
            }
            this.array = copy;          
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }
        }

        private void Shrink()
        {
            int[] copy = new int[this.array.Length / 2];
            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = array[i];
            }
            this.array = copy;
        }


        public int RemoveAt(int index)
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException("Invalid index");
            }
            int currElement = array[index];
            this.array[index] = default(int);
            this.Shift(index);
            this.Count--;

            if (Count == this.array.Length / 4)
            {
                this.Shrink();
            }

            return currElement;
        }

        public void Insert(int index, int value)
        {

            if (index > this.Count)
            {
                throw new ArgumentOutOfRangeException("Invalid index");
            }
            if (this.array.Length == this.Count)
            {
                this.Resize();
            }
            for (int i = this.Count; i == index + 1; i--)
            {
                this.array[i] = this.array[i - 1];
            }
            array[index] = value;
            this.Count++;
        }

        public bool Contains(int value)
        {
            foreach (var item in this.array)
            {
                if (item == value)
                {
                    return  true;
                }               
            }
            return false;
        }
    }
}
