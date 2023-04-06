using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\ventl\OneDrive\Рабочий стол\Projects\Study.CS.OOP\HomeWork9\Task2\Task2\SunshineOfYourLove.txt");

            var charCount = lines.Select(line => line.Length);
            foreach (int number in charCount)
                Console.WriteLine(number);

            var longestLine = lines.OrderBy(line => line.Length).LastOrDefault();
            var shortestLine = lines.OrderBy(line => line.Length).FirstOrDefault();
            Console.WriteLine($"Longest line - {longestLine} \n" +
                              $"Shortest line - {shortestLine}");

            var linesWithLove = lines.Where(line => line.ToLower().Contains("love"));
            foreach (string love in linesWithLove)
                Console.WriteLine(love);
        }
    }
}