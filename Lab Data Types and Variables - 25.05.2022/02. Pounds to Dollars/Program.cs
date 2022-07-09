using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that converts British pounds to US dollars formatted to the 3rd decimal point.
            //1 British Pound = 1.31 Dollars

            double pound = double.Parse(Console.ReadLine());
            double dolar = pound * 1.31;

            Console.WriteLine($"{dolar:f3}");
        }
    }
}
