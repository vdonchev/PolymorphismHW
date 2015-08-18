namespace Shapes
{
    using System;
    using Interfaces;
    using Shapes;

    public static class ShapesMain
    {
        public static void Main()
        {
            var figures = new IShape[]
            {
                new Circle(5), 
                new Rectangle(15, 33),
                new Rhombus(4, 2.1), 
                new Circle(50.003), 
                new Rectangle(1.5, 13),
                new Rectangle(9, 28),
                new Rhombus(11.5, 8), 
                new Circle(5.22), 
                new Circle(0.02), 
                new Circle(500), 
                new Rectangle(1.89, 33.333),
                new Rhombus(4, 20),
                new Circle(5), 
                new Rectangle(15, 33),
                new Rhombus(4, 2.1), 
                new Circle(50.003), 
                new Rectangle(1.5, 13),
                new Rectangle(9, 28),
                new Rhombus(11.5, 8), 
                new Circle(5.22), 
                new Circle(0.02), 
                new Circle(500), 
                new Rectangle(1.89, 33.333),
                new Rhombus(4, 20) 
            };

            foreach (var figure in figures)
            {
                Console.WriteLine(
                    "|{0,-15}|Area: {1,-15:F3}|Perimter: {2,-15:F3}",
                    figure.GetType().Name,
                    figure.CalculateArea(),
                    figure.CalculatePerimeter());
            }
        }
    }
}
