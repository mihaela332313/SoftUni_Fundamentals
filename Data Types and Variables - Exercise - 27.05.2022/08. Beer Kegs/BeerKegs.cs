using System;

namespace _08._Beer_Kegs
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            int kegsNumber = int.Parse(Console.ReadLine());
            double biggestKegVolume = double.MinValue;
            string biggestKeg = "";

            for (int currentKeg = 1; currentKeg <= kegsNumber; currentKeg ++)
            {
                string kegType = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > biggestKegVolume)
                {
                    biggestKegVolume = volume; 
                    biggestKeg = kegType;
                }

            }
            Console.WriteLine(biggestKeg);
        }
    }
}
