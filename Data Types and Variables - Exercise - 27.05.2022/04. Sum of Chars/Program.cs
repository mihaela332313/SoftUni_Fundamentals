using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int currentLetter = 1; currentLetter<= numberOfLines; currentLetter++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                 sum += (int)currentChar;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
