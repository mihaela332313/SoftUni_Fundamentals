using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    class SumAdjacentEqualNums
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            for(int currentIndex =0 ; currentIndex< numbers.Count-1; currentIndex++)
            {
                if(numbers[currentIndex] == numbers[currentIndex+1])
                {
                    numbers[currentIndex] += numbers[currentIndex + 1];
                    numbers.RemoveAt(currentIndex + 1);
                    currentIndex = -1;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
