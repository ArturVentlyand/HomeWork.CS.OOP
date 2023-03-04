using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some text: ");
            string userText = Console.ReadLine();

            for (int i = 0; i < userText.Length; i++)
            {
                if(i%2!=0)
                    Console.Write(userText[i]);
            }
        }
    }
}