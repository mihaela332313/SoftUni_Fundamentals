﻿using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive two whole numbers from the console representing the start and the end of a sequence of numbers. 
            //Your task is to print two lines:
            //On the first line, print all numbers from the start of the sequence to the end inclusive
            //On the second line, print the sum of the sequence in the format: "Sum: {sum}"

            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int currentNum = startNum; currentNum<= endNum; currentNum++)
            {
                sum += currentNum;
                Console.Write($"{currentNum} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
