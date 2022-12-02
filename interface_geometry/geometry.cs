using System;
using System.Collections.Generic;
using System.Text;

namespace interface_geometry
{
    interface IGeometry
    {
        void FindArea();

        void FindPerimeter();
    }
    class Circle : IGeometry
    {
        private float radius;

        public void TakeRadius()
        {
            Console.WriteLine("Enter the radius of the circle");
            radius = float.Parse(Console.ReadLine());
        }

        public void FindArea()
        {
            Console.WriteLine($"The area of the circle is {3.14 * (radius * radius)}");
        }

        public void FindPerimeter()
        {
            Console.WriteLine($"The perimeter of the circle is {2 * 3.14 * radius}");
        }
    }
    class Square : IGeometry
    {
        private float SquareLength;

        public void TakeSquareLength()
        {
            Console.WriteLine("\nEnter the length of the square:");
            SquareLength = float.Parse(Console.ReadLine());
        }
        public void FindArea()
        {
            Console.WriteLine($"The area of the square is {SquareLength * SquareLength}");
        }

        public void FindPerimeter()
        {
            Console.WriteLine($"The perimeter of the square is {4 * SquareLength}");
        }
    }
    class Rectangle : IGeometry
    {
        private float RectangleLength;
        private float RectangleBreadth;

        public void TakeRectangleLengthBreadth()
        {
            Console.WriteLine("\nEnter the length of the rectangle:");
            RectangleLength = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the breadth of the rectangle:");
            RectangleBreadth = float.Parse(Console.ReadLine());
        }

        public void FindArea()
        {
            Console.WriteLine($"The area of the rectangle is {RectangleLength * RectangleBreadth}");
        }

        public void FindPerimeter()
        {
            Console.WriteLine($"The perimeter of the rectangle is {2 * (RectangleLength + RectangleBreadth)}");
        }
    }
}
