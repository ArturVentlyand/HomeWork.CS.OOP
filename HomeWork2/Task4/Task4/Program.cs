using System;

namespace Task4 
{ 
    internal class Program
    {
        struct Dog
        {
            public string Name;
            public string Mark;
            public int Age;

            public override string ToString()
            {
                return String.Format($"\nName - {Name}; \nMark - {Mark}, \nAge - {Age}");
            }
        }

        static void Main(string[] args)
        {
            Dog myDog;
            Console.Write("Enter a name your dog: ");
            myDog.Name = Console.ReadLine();

            Console.Write("Enter a mark your dog: ");
            myDog.Mark = Console.ReadLine();
            
            Console.Write("Enter a age your dog: ");
            myDog.Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dog info: {myDog}");
        }
    }
}