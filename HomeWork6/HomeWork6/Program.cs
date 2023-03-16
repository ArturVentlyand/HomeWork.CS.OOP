using System;

namespace HomeWork6
{

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number of numbers for check: ");
                int sizeNumOf = int.Parse(Console.ReadLine());
                int[] numsCheck = new int[sizeNumOf];
                int endRange = 0;

                Console.WriteLine("Enter start and end of range: ");

                Console.Write("Start: ");
                numsCheck[0] = int.Parse(Console.ReadLine());

                Console.Write("End: ");
                endRange = int.Parse(Console.ReadLine());

                Console.WriteLine("Remember!!!");
                Console.WriteLine("The number must be in the range of!");
                Console.WriteLine("The number must be greater than the previous number!");
                for (int i = 0; i < sizeNumOf; i++)
                {
                    if (i > 0)
                    {
                        Console.Write($"Enter {i} number in range [{numsCheck[0]}, {endRange}]: ");
                        numsCheck[i] = int.Parse(Console.ReadLine());
                        if (numsCheck[i] >= numsCheck[i - 1])
                            ReadNumber(numsCheck[i], endRange);
                        else
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"ERROR! {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR! {ex.Message}");
            }
            

        }
        static int ReadNumber(int start, int end)
        {
            if (start > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            return start;
        }
    }
}