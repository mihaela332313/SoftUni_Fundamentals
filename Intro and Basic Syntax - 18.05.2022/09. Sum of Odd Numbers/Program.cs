using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the next n odd numbers, starting from 1, separated by new lines.
            //On the last line, print the sum of these numbers.

            int amountOfOdds = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i<= amountOfOdds; i++)
            {
                int odd = (2 * i) - 1;
                sum += odd;
                Console.WriteLine(odd);

            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
