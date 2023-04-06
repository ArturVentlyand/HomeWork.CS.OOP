using HomeWork8;
using System;
using System.Linq;
using System.Xml.Linq;

namespace HomeWork9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string writePathFile = @"C:\Users\ventl\OneDrive\Рабочий стол\Projects\Study.CS.OOP\HomeWork9\Task1\Task1\TextFile.txt";

            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle("Cicle", 3));
            shapes.Add(new Square("Square", 2));
            shapes.Add(new Circle("Circle", 5));
            shapes.Add(new Square("Square", 4));
            shapes.Add(new Circle("Circle", 2.5));
            shapes.Add(new Square("Square", 3.5));

            var areaShapes = shapes.Where(shape => shape.Area() >= 10 && shape.Area() <= 100).ToList();
            var nameContainsLetter = shapes.Where(shape => shape.Name.ToLower().Contains('a')).ToList();
            using (StreamWriter writer = new StreamWriter(writePathFile))
            {
                foreach (var shape in areaShapes)
                    writer.WriteLine(shape.Area().ToString());

                Console.WriteLine();

                foreach (var shape in nameContainsLetter)
                    writer.WriteLine(shape.Name);
            }

            shapes.RemoveAll(shape => shape.Perimeter() < 5);
            foreach (var shape in shapes)
            {
                shape.Display();
                Console.WriteLine();
            }
        }
    }
}