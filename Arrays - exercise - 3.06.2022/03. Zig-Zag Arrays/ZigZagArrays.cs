using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class ZigZagArrays
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int[] evenArray = new int[numberOfLines];
            int[] oddArray = new int[numberOfLines];

            for( int currentIndex = 0; currentIndex < evenArray.Length; currentIndex++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (currentIndex%2 == 0)
                {
                    evenArray[currentIndex] = numbers[0];
                    oddArray[currentIndex] = numbers[1];
                }
                else
                {
                    evenArray[currentIndex] = numbers[1];
                    oddArray[currentIndex] = numbers[0];
                }

            }

            Console.WriteLine(string.Join(" ", evenArray));
            Console.WriteLine(string.Join(" ", oddArray));
        }
    }
}
