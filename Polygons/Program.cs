using System;
using Polygons.Library;
using static System.Console;

namespace Polygons
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            DisplayPoligon("Square", square);

            var triangle = new Triangle(5);
            DisplayPoligon("Trianle", triangle);

            var octagon = new Octagon(5);
            DisplayPoligon("Octagon", octagon);

            ReadKey();
        }

        private static void DisplayPoligon(string polygonType, dynamic polygon)
        {
            try
            {
                WriteLine($"{polygonType} Number of Sides: {polygon.NumberOfSides}");
                WriteLine($"{polygonType} Side Length: {polygon.SideLength}");
                WriteLine($"{polygonType} Perimeter: {polygon.GetPerimeter()}");
                WriteLine($"{polygonType} Area: {Math.Round(polygon.GetArea(), 2)}");
                WriteLine();

            }
            catch (Exception ex)
            {
                WriteLine(
                    $"Exception was thrown while trying to process {polygonType}:\n   {ex.GetType().Name}");
                WriteLine();
            }
        }
        
    }
}
