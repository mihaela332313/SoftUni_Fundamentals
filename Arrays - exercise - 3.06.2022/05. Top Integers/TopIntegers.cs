using System;
using System.Linq;

namespace _05._Top_Integers
{
    class TopIntegers
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for(int currentIndex = 0; currentIndex<inputArray.Length; currentIndex++)
            {
                bool topInteger = true;
                for ( int nextIndex = currentIndex + 1; nextIndex< inputArray.Length; nextIndex++)
                {
                    if (inputArray[currentIndex] <= inputArray[nextIndex])
                    {
                        topInteger = false;
                        break;
                    }
                }

                if (topInteger)
                {
                    Console.Write($"{inputArray[currentIndex]} ");
                }
            }
        }
    }
}
