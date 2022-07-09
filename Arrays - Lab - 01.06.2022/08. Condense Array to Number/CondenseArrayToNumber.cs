using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[numbers.Length - 1];

            while (numbers.Length >1)
            {
                for (int currentIndex = 0; currentIndex < numbers.Length - 1; currentIndex++)
                {
                    condensed[currentIndex] = numbers[currentIndex] + numbers[currentIndex + 1];

                    if (currentIndex == numbers.Length -2)
                    {
                        numbers = condensed;
                        condensed = new int[numbers.Length - 1];
                    }
                }

            }
            Console.WriteLine(numbers[0]);
            

        }
    }
}
