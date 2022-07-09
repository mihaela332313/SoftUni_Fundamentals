using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int currentIndex = 0; currentIndex < numbersList.Count; currentIndex++)
            {
                if (numbersList[currentIndex] < 0)
                {
                    numbersList.Remove(numbersList[currentIndex]);
                    currentIndex--;
                }
            }
            numbersList.Reverse();

            if(numbersList.Count == 0)
            {
                Console.WriteLine("empty");
            }

            Console.WriteLine(string.Join(" ", numbersList));
        }

    }
}
