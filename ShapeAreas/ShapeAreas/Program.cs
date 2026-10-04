using System;
using System.Collections.Generic;

namespace ShapeAreasExercise
{
    // Shape Class:
    public class Shape
    {
        // Virtual CalculateArea Method:
        public virtual double CalculateArea()
        {
            return 0;
        }
    }

    // Circle Class:
    public class Circle : Shape
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Circle Method that overrides parent method:
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Rectangle Class:
    public class Rectangle : Shape
    {
        public double Width;
        public double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        //  Rectangle Method that overrides parent method:
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Shape List than contain shapes:
            List<Shape> shapes = new List<Shape>
            {
                new Circle(5),
                new Rectangle(4, 6)
            };

            // (Runtime Type) and areas:
            foreach (Shape shape in shapes)
            {
                string runtimeType = shape.GetType().Name;
                double area = shape.CalculateArea();

                Console.WriteLine("Type: " + runtimeType);
                Console.WriteLine(" ");
                Console.WriteLine(" Area: " + area);
                Console.WriteLine("----------------------------------------");

            }
        }
    }
}