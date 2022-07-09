using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which receives a number – n and prints a triangle from 1 to n.

            int numOfRows = int.Parse(Console.ReadLine());

            for (int row = 1; row <= numOfRows; row++)
            {
                for (int column= 1; column<= row; column++)
                {
                    Console.Write($"{row} ");
                           
                }
                Console.WriteLine();
            }

        }

    }
}
