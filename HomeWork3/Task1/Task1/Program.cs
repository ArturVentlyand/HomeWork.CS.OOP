using System;

namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a start of the range: ");
            int startRange = int.Parse(Console.ReadLine());

            Console.Write("Enter a end of the range: ");
            int endRange = int.Parse(Console.ReadLine());

            int countNumber = 0;

            for (int i = startRange; i <= endRange; i++)
            {
                if (i%3==0)
                    countNumber++;
            }

            Console.Write($"Numbers: {countNumber}");
        }
    }
}