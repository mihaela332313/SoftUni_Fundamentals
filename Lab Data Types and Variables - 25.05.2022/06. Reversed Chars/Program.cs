using System;

namespace _06._Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that takes 3 lines of characters and prints them in reversed order with a space between them.

            char firstChar = char.Parse(Console.ReadLine());
            char secondCharr = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());

            Console.WriteLine($"{thirdChar} {secondCharr} {firstChar}");


        }
    }
}
