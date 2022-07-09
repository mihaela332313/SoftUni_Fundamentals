using System;

namespace _02._Common_Elements
{
    class CommonElements
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(); // i am mihaela zelkovska
            string[] secondArray = Console.ReadLine().Split(); // I´m mihaela Zelkovska

            for (int currentIndex = 0; currentIndex< secondArray.Length; currentIndex++)
            {
                for(int currentIndexSecArr = 0; currentIndexSecArr< firstArray.Length; currentIndexSecArr++ )
                {
                    if (firstArray[currentIndex] == secondArray[currentIndexSecArr])
                    {
                        Console.Write($"{secondArray[currentIndexSecArr]} ");
                    }
                }
            }
        }
    }
}
