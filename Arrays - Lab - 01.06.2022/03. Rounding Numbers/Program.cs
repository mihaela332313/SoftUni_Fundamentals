using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] roundedNums = new int[numbers.Length];

            for (int numberIndex = 0; numberIndex < numbers.Length; numberIndex++)
            {
                roundedNums[numberIndex] = (int)Math.Round(numbers[numberIndex], MidpointRounding.AwayFromZero);

            }
             for (int numberIndex = 0; numberIndex < numbers.Length; numberIndex++)
            {
                Console.WriteLine($"{numbers[numberIndex]} => {roundedNums[numberIndex]}"); 
            }

        }
    }
}
