using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 10 integer numbers: ");
            int[] array = new int[10];
            int sum = 0;
            int prod = 1;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length-1; i++)
            {
                if (i <= 4 && array[i] > 0)
                {
                    sum += array[i];
                }
                if (i > 4 && array[i] < 0)
                {
                    prod = prod * array[i];
                }
            }

            Console.WriteLine($"Sum = {sum}, Product = {prod}");
        }
    }
}