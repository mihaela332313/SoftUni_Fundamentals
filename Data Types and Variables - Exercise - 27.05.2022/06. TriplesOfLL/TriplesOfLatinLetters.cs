using System;

namespace _06._TriplesOfLL
{
    class TriplesOfLatinLetters
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (char firstLetter = 'a'; firstLetter< 'a'+number; firstLetter++)
            {
                for (char secondLetter = 'a'; secondLetter < 'a' + number; secondLetter++ )
                {
                    for ( char thirdLetter = 'a'; thirdLetter < 'a' + number; thirdLetter++)
                    {
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");

                    }
                }
            }
        }
    }
}
