using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBox
{
    public class Box
    {
        private double lenght;
        private double widht;
        private double height;
        public Box(double lenght, double widht, double height)
        {
            Lenght = lenght;
            Widht = widht;
            Height = height;
        }
        public double Lenght {
            get => this.lenght;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.lenght = value;
            }
        }

        public double Widht
        {
            get => this.widht;
            private set
            {

                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.widht = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {

                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }
        public double GetSurfaceArea()
        {
            double result = (2 * this.lenght * this.widht) + (2 * this.lenght * this.height) + (2 * this.widht * this.height);
            return result;
        }

        public double GetVolume()
        {
            return this.lenght * this.widht * this.height;
        }

        public double GetLateralSurFaceArea()
        {
            return 2 * this.lenght * this.height + 2 * this.widht * this.height;
        }

    }
}
