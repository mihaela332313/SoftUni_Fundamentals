using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int divider = int.Parse(Console.ReadLine());
            double multiplier = double.Parse(Console.ReadLine());

            Console.WriteLine((firstNumber+secondNumber)/ divider * multiplier);


        }
    }
}
