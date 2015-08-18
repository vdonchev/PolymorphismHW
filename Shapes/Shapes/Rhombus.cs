namespace Shapes.Shapes
{
    using System;

    public class Rhombus : BasicShape
    {
        public Rhombus(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            return (this.Height * this.Width) / 2;
        }

        public override double CalculatePerimeter()
        {
            var perimeter = 2 * Math.Sqrt(Math.Pow(this.Width, 2) + Math.Pow(this.Height, 2));
            return perimeter;
        }
    }
}