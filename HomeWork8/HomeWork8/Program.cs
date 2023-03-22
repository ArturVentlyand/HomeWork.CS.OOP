using System;
using System.Xml.Linq;

namespace HomeWork8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool tryAgain = true;
            int countShapes = 1;

            while (tryAgain)
            {
                try
                {
                    Console.Write("Enter count a shapes: ");
                    countShapes = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    tryAgain = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please, try again \n");
                    continue;
                }
            }

            List<Shape> shapes = new List<Shape>(countShapes);
            string inputUser;
            string[] nameShape = new string[countShapes];
            double[] item = new double[countShapes];
            double largestPerimeter = 0;
            double[] perimetersShapes = new double[countShapes];

            Console.WriteLine($"Enter data of {countShapes} different shapes: ");
            for (int i = 0; i < countShapes; i++)
            {
                try
                {
                    Console.Write($"Enter a name {i + 1} shape: \n" +
                                      $"0 = Circle or 1 = Square -> ");
                    inputUser = Console.ReadLine();

                    Console.Write($"Enter a element {i + 1} shape: ");
                    item[i] = double.Parse(Console.ReadLine());

                    if (inputUser == "0")
                    {
                        nameShape[i] = "Circle";
                        shapes.Add(new Circle(nameShape[i], item[i]));
                    }
                    else if (inputUser == "1")
                    {
                        nameShape[i] = "Square";
                        shapes.Add(new Square(nameShape[i], item[i]));
                    }
                    else
                        throw new Exception();

                    Console.WriteLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Please, try again \n");
                    i--;
                }
            }

            foreach (Shape shape in shapes)
            {
                shape.Display();
                Console.WriteLine();
            }

            foreach (Shape shape in shapes)
            {
                for (int i = 0; i < countShapes; i++)
                {
                    perimetersShapes[i] = shape.Perimeter(item[i]);
                    if (i > 0)
                    {
                        if (perimetersShapes[i] > perimetersShapes[i - 1])
                            largestPerimeter = perimetersShapes[i];
                        else
                            largestPerimeter = perimetersShapes[i - 1];
                    }
                    else
                        largestPerimeter = perimetersShapes[i];
                }
            }

            Console.WriteLine($"This largest perimeter = {largestPerimeter}");
            Console.WriteLine();

            shapes.Sort();

            Console.WriteLine("Sorted list shapes: ");
            foreach (Shape shape in shapes)
            {
                shape.DisplayArea();
            }
        }
    }
}