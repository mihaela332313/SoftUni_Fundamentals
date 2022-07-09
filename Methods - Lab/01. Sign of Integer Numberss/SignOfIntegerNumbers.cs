using System;

namespace _01._Sign_of_Integer_Numberss
{
    class SignOfIntegerNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintSign(number);

        }

        static void PrintSign(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative. ");

            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive. ");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero. ");

            }

        }
    }
}
