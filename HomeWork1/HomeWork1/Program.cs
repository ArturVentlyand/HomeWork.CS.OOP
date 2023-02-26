using System;

namespace HomeWork1 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Human! \nPlease, enter number task (1, 2 or 3):");

            int numTask = int.Parse(Console.ReadLine());

            switch (numTask)
            {
                case 1:
                    Console.Write("Please, enter side of a square: ");
                    int sideSquare = int.Parse(Console.ReadLine());

                    int areaSquare = sideSquare * sideSquare;
                    int perimeterSquare = sideSquare * 4;

                    Console.WriteLine($"This area of the square: {areaSquare}. \nThis perimeter of the square: {perimeterSquare}.");
                    break;

                case 2:
                    Console.WriteLine("What is your name, Human?");
                    string nameUser = Console.ReadLine();

                    Console.WriteLine($"How old are you, {nameUser}?");
                    int ageUser = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Your personal information:\nName - {nameUser};\nAge - {ageUser}.");
                    break;

                case 3:
                    Console.Write("Please, enter radius of a circle: ");
                    double radiusCircle = double.Parse(Console.ReadLine());

                    double lengthCircle = 2 * Math.PI * radiusCircle;
                    double areaCircle = Math.PI * radiusCircle * radiusCircle;
                    double volumeCircle = (4 * Math.PI * radiusCircle * radiusCircle * radiusCircle) / 3;

                    Console.WriteLine($"Length of the circle = {lengthCircle:F2}");
                    Console.WriteLine($"Area of the circle = {areaCircle:F2}");
                    Console.WriteLine($"Volume of the circle = {volumeCircle:F2}");
                    break;

                default:
                    Console.WriteLine("You entered a wrong number task");
                    break;
            }

            
        }
    }
}