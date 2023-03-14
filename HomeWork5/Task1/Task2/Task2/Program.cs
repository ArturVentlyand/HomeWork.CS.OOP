using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> ds7 = new Dictionary<uint, string>();
            //ds7.Add(14001, "Lust");
            //ds7.Add(14002, "Gluttony");
            //ds7.Add(14003, "Greed");
            //ds7.Add(14004, "Sloth");
            //ds7.Add(14005, "Wrath");
            //ds7.Add(14006, "Envy");
            //ds7.Add(14007, "Pride");


            Console.WriteLine("Enter ID and Name to Seven Deadly Sins (year start The Renaissance + number sins [1-7]): ");
            
            uint id = 0;
            string name;
            for (int i = 1; i <= 7; i++)
            {
                Console.Write($"{i}. ID: ");
                id = uint.Parse(Console.ReadLine());

                Console.Write($"{i}. Name: ");
                name = Console.ReadLine();
                ds7.Add(id, name);
                Console.Clear();
            }

            Console.Write("Enter ID: ");
            uint inputUser = uint.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(ds7[inputUser]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Not find sin!");
            }



        }
    }
}