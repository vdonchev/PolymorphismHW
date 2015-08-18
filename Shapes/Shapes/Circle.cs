namespace Shapes.Shapes
{
    using System;
    using Interfaces;

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Radius can't be negative");
                }

                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            return this.Radius * this.Radius * Math.PI;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }
    }
}