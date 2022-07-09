using System;

namespace _09.SpiceMustFlow
{
    class SpiceMustFlow
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            const  int workersConsume = 26;
            int sum = 0;

            while (startingYield >= 100)
            {
                days++;
                int extractedSpices = startingYield - workersConsume;

                sum += extractedSpices;

                startingYield -= 10;

                if ( startingYield < 100 && startingYield >= workersConsume)
                {
                    sum -= workersConsume;
                }
            }
            Console.WriteLine(days);
            Console.WriteLine(sum);
        }
    }
}
