using System;

namespace _05._PrintASCII
{
    class PrintPartOfAsciiTable
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (int currentIndex = startIndex; currentIndex<= endIndex; currentIndex++)
            {
                Console.Write($"{(char)currentIndex} ");
            }
        }
    }
}
