using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class CardsGame
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstPlayerCards.Count > 0 && secondPlayerCards.Count>0)
            {
                int firstPlayerCurrentCard = firstPlayerCards[0];
                int secondPlayerCurrentCard = secondPlayerCards[0];

                if (firstPlayerCurrentCard> secondPlayerCurrentCard)
                {
                    firstPlayerCards.Add(firstPlayerCurrentCard);
                    firstPlayerCards.Add(secondPlayerCurrentCard);
                }
                else if (firstPlayerCurrentCard < secondPlayerCurrentCard)
                {
                    secondPlayerCards.Add(secondPlayerCurrentCard);
                    secondPlayerCards.Add(firstPlayerCurrentCard);
                }

                firstPlayerCards.Remove(firstPlayerCurrentCard);
                secondPlayerCards.Remove(secondPlayerCurrentCard);

                if (firstPlayerCards.Count == 0)
                {
                    int sum = secondPlayerCards.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }

                if (secondPlayerCards.Count == 0)
                {
                    int sum = firstPlayerCards.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }

        }
    }
}
