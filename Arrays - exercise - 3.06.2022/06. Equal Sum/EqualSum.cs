using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class EqualSum                // 1 2 3 3 
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;

            for (int currentIndex = 0; currentIndex < array.Length; currentIndex++)
            {
                if (array.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }

                leftSum = 0;
                for( int leftElement = currentIndex; leftElement > 0; leftElement--)
                {
                    int nextLeftElementPosition = leftElement - 1; 
                    if ( leftElement > 0)
                    {
                        leftSum += array[nextLeftElementPosition];
                    }
                }

                rightSum = 0;
                for( int rightElement = currentIndex; rightElement<array.Length; rightElement++ )
                {
                    int nextRightElementPosition = rightElement + 1;
                    if( rightElement < array.Length -1)
                    {
                        rightSum += array[nextRightElementPosition];
                    }
                }

                if ( rightSum == leftSum)
                {
                    Console.WriteLine(currentIndex);
                    return;
                }

            }

            Console.WriteLine("no");
        }
    }
}
