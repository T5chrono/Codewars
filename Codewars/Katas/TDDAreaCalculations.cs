using System;
using System.Linq;

namespace Codewars.Katas
{
    public class TDDAreaCalculations
    {
        public double GetTotalArea(params Shape[] shapes)
        {
            if (shapes.Length == 0) return 0;
            double totalArea = shapes.Sum(shape => shape.CalculateArea());
            return Math.Round(totalArea, 2);
        }
    }

    public interface Shape
    {
        public double CalculateArea();
    }

    public class Square : Shape
    {
        private readonly double side;
        public Square(double side)
        {
            this.side = side;
        }

        public double CalculateArea()
        {
            return side * side;
        }
    }

    public class Rectangle : Shape
    {
        private readonly double _width;
        private readonly double _height;
        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public double CalculateArea()
        {
            return _width * _height;
        }
    }

    public class Triangle : Shape
    {
        private readonly double _triangleBase;
        private readonly double _triangleHeight;
        public Triangle(double triangleBase, double triangleHeight)
        {
            _triangleBase = triangleBase;
            _triangleHeight = triangleHeight;
        }

        public double CalculateArea()
        {
            return 0.5 * _triangleBase * _triangleHeight;
        }
    }

    public class Circle : Shape
    {
        private readonly double _radius;
        private const double PI = Math.PI;
        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            return _radius * _radius * PI;
        }
    }
}
