using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class KaminoFactory
    {
        static void Main(string[] args)
        {
            int sequencesLenght = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int[] dna = new int[sequencesLenght];
            int sum = 0;
            int longestSequences =-1;
            int startingIndex = -1;
            int dnaSamples = 0;

            int sample = 0;


            while (command != "Clone them!")
            {

                sample++;
                int[] currentDna = command.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int currentStartIndex = 0;
                int currentEndIndex = 0;
                int currentDnaSum = 0;
                int match = 0;
                int currLongestMatch = 0;

                bool bestDnaSample = false;


                for (int currentIndex = 0; currentIndex < currentDna.Length; currentIndex++)
                {

                    if (currentDna[currentIndex] != 1)
                    {
                        match = 0;
                        continue;
                    }

                    match++;
                    if (match > currLongestMatch)
                    {
                        currLongestMatch = match;
                        currentEndIndex = currentIndex;
                    }
                }

                currentStartIndex = currentEndIndex - currLongestMatch + 1;
                currentDnaSum = currentDna.Sum();

                if (currLongestMatch > longestSequences)
                {
                    bestDnaSample = true;
                }
                else if (currLongestMatch == longestSequences)
                {
                    if (currentStartIndex < startingIndex)
                    {
                        bestDnaSample = true;
                    }
                    else if (currentStartIndex == startingIndex)
                    {
                        if (currentDnaSum > sum)
                        {
                            bestDnaSample = true;
                        }
                    }
                }
                

                if (bestDnaSample)
                {
                    dna = currentDna;
                    longestSequences = currLongestMatch;
                    startingIndex = currentStartIndex;
                    sum = currentDnaSum;
                    dnaSamples = sample;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {dnaSamples} with sum: {sum}.");
            Console.WriteLine(string.Join(" ", dna));
        }
    }
}
