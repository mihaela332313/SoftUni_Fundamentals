using System;
using System.Linq;

namespace _07._MaxSequenceofEq.Elem_
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {       
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int equalsCounter = 1;
            int longestSequenceOfEqualEl = 0;
            int matchElement = 0;


            for (int currentIndex = 0; currentIndex < array.Length - 1; currentIndex++)
            {
                if (array[currentIndex] == array[currentIndex + 1])
                {
                    equalsCounter++;

                    if (equalsCounter > longestSequenceOfEqualEl)
                    {
                        longestSequenceOfEqualEl = equalsCounter;
                        matchElement = array[currentIndex];
                    }
                }
                else
                {
                    equalsCounter = 1;
                }
            }
            if(longestSequenceOfEqualEl == 0)
            {
                Console.Write($"{equalsCounter}");
            }
            else
            {
                for (int currentMatchElement = 0; currentMatchElement < longestSequenceOfEqualEl; currentMatchElement++)
                {
                    Console.Write($"{matchElement} ");
                }
            }
        }
    }
}
