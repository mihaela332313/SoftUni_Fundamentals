using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that receives a single integer. Your task is to find the sum of its digits.

            string input = Console.ReadLine(); //657
            int sum = 0;
            int number = int.Parse(input);

            for ( int currentDigit = 0; currentDigit < input.Length; currentDigit++)
            {
                sum += number % 10; // 7
                number /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
