using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first number: ");
            int firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter a third number: ");
            int thirdNum = int.Parse(Console.ReadLine());

            int max, min;
            max = firstNum > secondNum ? firstNum : secondNum;
            if (max < thirdNum)
                max = thirdNum;

            min = firstNum < secondNum ? firstNum : secondNum;
            if (min > thirdNum)
                min = thirdNum;

            Console.WriteLine($"max = {max}, min = {min}");
        }
    }
}