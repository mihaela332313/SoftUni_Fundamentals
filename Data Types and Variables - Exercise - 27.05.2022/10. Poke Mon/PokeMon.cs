using System;

namespace _10._Poke_Mon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            byte exhaustionFactor = byte.Parse(Console.ReadLine());
            int targetReached = 0;
            int initialPower = power;

            while (power >= distance)
            {
                
                    targetReached++;
                    power -= distance;
                
                if (power == 0.5*initialPower && exhaustionFactor > 0 )
                {
                    power /= (int)exhaustionFactor;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(targetReached);

             
            
        }
    }
}
