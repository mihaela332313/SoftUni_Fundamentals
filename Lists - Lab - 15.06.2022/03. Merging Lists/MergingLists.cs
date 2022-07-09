using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class MergingLists
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> mergedList = new List<int>();

            int longestListCount = Math.Max(firstList.Count, secondList.Count);

            for (int currentIndex = 0; currentIndex< longestListCount; currentIndex++)
            {
                if(firstList.Count> currentIndex)
                {
                    mergedList.Add(firstList[currentIndex]);
                }

                if (secondList.Count > currentIndex)
                {
                    mergedList.Add(secondList[currentIndex]);
                }
            }

            Console.WriteLine(string.Join(" ", mergedList));
         
        }      
        
    }
}
