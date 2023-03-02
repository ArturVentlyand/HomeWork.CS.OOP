using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first float number: ");
            double firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second float number: ");
            double secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third float number: ");
            double thirdNum = double.Parse(Console.ReadLine());

            Console.WriteLine((firstNum >= -5) && (firstNum <= 5) ? true : false);
            Console.WriteLine((secondNum >= -5) && (secondNum <= 5) ? true : false);
            Console.WriteLine((thirdNum >= -5) && (thirdNum <= 5) ? true : false);
        }
    }
}
