using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class EqualArrays
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int currentIndex = 0; currentIndex< firstArray.Length; currentIndex++)
            {
                if ( firstArray[currentIndex] != secondArray[currentIndex])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {currentIndex} index");
                    return;
                }
                else
                {
                    sum += firstArray[currentIndex];
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
