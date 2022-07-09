using System;

namespace _02._Print_Numbers_in_RevOrder
{
    class NumberInReversedOrder
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int numberIndex = 0; numberIndex < n; numberIndex++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers[numberIndex] = currentNumber;
            }

            for ( int currentNumber = numbers.Length - 1; currentNumber >= 0; currentNumber--)
            {
                Console.Write(numbers[currentNumber] + " ");
            }
        }
    }
}
