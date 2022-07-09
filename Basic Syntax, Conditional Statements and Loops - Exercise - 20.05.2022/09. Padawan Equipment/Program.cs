using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {

            double moneyToSpend = double.Parse(Console.ReadLine());
            int numOfStudents = int.Parse(Console.ReadLine());
            double lightsaberSinglePrice = double.Parse(Console.ReadLine());
            double robeSinglePrice = double.Parse(Console.ReadLine());
            double beltSinglePrice = double.Parse(Console.ReadLine());

          
            double freeBelts = numOfStudents / 6;
            double moneyNeeded = Math.Ceiling(numOfStudents * 1.1) * lightsaberSinglePrice + 
            (numOfStudents * robeSinglePrice) + (numOfStudents - freeBelts) * beltSinglePrice;

            if ( moneyToSpend >= moneyNeeded)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(moneyNeeded - moneyToSpend):f2}lv more.");
            }

        }
    }
}
