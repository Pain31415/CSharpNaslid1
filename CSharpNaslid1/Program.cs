using System;
using GeometricShapes;

namespace GeometricShapesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 10);

            double rectangleArea = rectangle.CalculateArea();

            Console.WriteLine($"Площа прямокутника: {rectangleArea}");
        }
    }

}