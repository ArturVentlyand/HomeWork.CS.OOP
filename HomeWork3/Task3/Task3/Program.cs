using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a name of the drink: ");
            string nameDrink = Console.ReadLine();
            double priceDrink = 0;

            switch (nameDrink.ToLower())
            {
                case "tea":
                case "coffee":
                    priceDrink = 1.5;
                    Console.WriteLine($"{nameDrink} = ${priceDrink}");
                    break;
                case "juice":
                    priceDrink = 3.0;
                    Console.WriteLine($"{nameDrink} = ${priceDrink}");
                    break;
                case "water":
                    priceDrink = 2.5;
                    Console.WriteLine($"{nameDrink} = ${priceDrink}");
                    break;
                default:
                    break;
            }
        }
    }
}