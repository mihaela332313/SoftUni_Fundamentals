﻿using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class EvenAndOddSubtraction
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;

            foreach(int number in numbers)
            {
                if (number%2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }
            Console.WriteLine(evenSum - oddSum);
        }
    }
}
