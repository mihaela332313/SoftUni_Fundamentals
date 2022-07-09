using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that receives an integer as an input.
            //Print the 10 times table for this integer. See the examples below for more information.

            int multiplier = int.Parse(Console.ReadLine());
            for (int i = 1; i<= 10; i++)
            {
                Console.WriteLine($"{multiplier} X {i} = {multiplier * i}");
            }
        }
    }
}
