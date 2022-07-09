using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Snowballs
    {
        static void Main(string[] args)
        {
            byte ballsNumber = byte.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            BigInteger highestValue = int.MinValue;
            short snowballSnow = 0;
            short snowballTime = 0;
            byte snowballQuality = 0;
            string  bestSnowball = "";

            for ( int currentBall = 1; currentBall <= ballsNumber; currentBall++ )
            {
                snowballSnow = short.Parse(Console.ReadLine());
                snowballTime = short.Parse(Console.ReadLine());
                snowballQuality = byte.Parse(Console.ReadLine());

                int snowballParameter = snowballSnow / snowballTime;
                snowballValue = BigInteger.Pow(snowballParameter, snowballQuality);

                if ( snowballValue > highestValue)
                {
                    highestValue = snowballValue;
                    bestSnowball = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})";
                }

            }
           
            Console.WriteLine(bestSnowball);
        }
    }
}
