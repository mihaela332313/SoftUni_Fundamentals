using System;

namespace _07.WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            const int CAPACITY = 255;
            int inflowNumber = int.Parse(Console.ReadLine());
            int totalQuantity = 0;

            for (int i = 1; i <= inflowNumber; i++)
            {
                int water = int.Parse(Console.ReadLine());

                if (totalQuantity + water > CAPACITY)
                {
                    Console.WriteLine("Insufficient capacity!");                   
                }
                else
                {
                    totalQuantity += water;
                }
            }
            Console.WriteLine(totalQuantity);

        }
    }
}
