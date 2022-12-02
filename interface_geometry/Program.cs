using System;

namespace interface_geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    Geometry!\n");

            var CircleGeometry = new Circle();
            CircleGeometry.TakeRadius();
            CircleGeometry.FindArea();
            CircleGeometry.FindPerimeter();

            var SquareGeometry = new Square();
            SquareGeometry.TakeSquareLength();
            SquareGeometry.FindPerimeter();
            SquareGeometry.FindArea();

            var RectangleGeometry = new Rectangle();
            RectangleGeometry.TakeRectangleLengthBreadth();
            RectangleGeometry.FindArea();
            RectangleGeometry.FindPerimeter();
        }
    }
}
