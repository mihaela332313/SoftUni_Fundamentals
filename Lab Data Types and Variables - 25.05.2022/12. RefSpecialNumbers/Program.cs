using System;

namespace _12._RefSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int currentDigit = i;

                while (currentDigit > 0)
                {
                   sum += currentDigit % 10;
                   currentDigit /= 10;
                }

                bool isspecialnumber = (sum == 5) || (sum == 7) || (sum == 11);
                
                Console.WriteLine($"{i} -> {isspecialnumber}");
               
            }
        }
    }
}
