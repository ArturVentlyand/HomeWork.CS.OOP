using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of month: ");
            int numMonth = int.Parse(Console.ReadLine());
            int numDays = 0;

            switch (numMonth)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine($"Days in {numMonth} = {numDays = 31}");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"Days in {numMonth} = {numDays = 30}"); break;
                case 2:
                    Console.WriteLine($"Days in {numMonth} = {numDays = 28}"); break;
                default:
                    break;
            }
        }
    }
}