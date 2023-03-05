using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some text:");
            string textUser = Console.ReadLine();
            int countChar = 0;

            for (int i = 0; i < textUser.Length; i++)
            {
                if (textUser[i] == 'a')
                    countChar++;
                if (textUser[i] == 'o')
                    countChar++;
                if (textUser[i] == 'i')
                    countChar++;
                if (textUser[i] == 'e')
                    countChar++;
            }
            Console.WriteLine($"Count of characters: {countChar}");

        }
    }
}
