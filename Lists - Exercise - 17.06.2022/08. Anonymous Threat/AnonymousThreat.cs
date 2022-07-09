using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class AnonymousThreat
    {
        static void Main(string[] args)
        {
            List<string> arrayOfData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                List<string> instructions = Console.ReadLine().Split().ToList();
                string command = instructions[0];

                if (command == "3:1") break;

                int start = int.Parse(instructions[1]);
                int end = int.Parse(instructions[2]);

                string concatWord = "";

                if (end > arrayOfData.Count - 1 || end < 0)
                {
                    end = arrayOfData.Count - 1;
                }

                if (start < 0 || start > arrayOfData.Count - 1)
                {
                    start = 0;
                }

                if (command == "merge")
                {
                    for (int i = start; i <= end; i++)
                    {
                        concatWord += arrayOfData[i];
                    }

                    arrayOfData.RemoveRange(start, end - start + 1);
                    arrayOfData.Insert(start, concatWord);

                }
                else if (command == "divide")
                {
                    List<string> dividedWord = new List<string>();
                    int indexOfElement = start;
                    string elementToBeDivided = arrayOfData[indexOfElement];
                    int partitions = int.Parse(instructions[2]);
                    int equalParts = elementToBeDivided.Length/partitions;

                    arrayOfData.RemoveAt(indexOfElement);

                    for( int currentIndex = 0; currentIndex< partitions; currentIndex++)
                    {
                        if (currentIndex== partitions-1)
                        {
                            dividedWord.Add(elementToBeDivided.Substring(currentIndex*equalParts));
                        }
                        else
                        {
                            dividedWord.Add(elementToBeDivided.Substring(currentIndex * equalParts, equalParts));
                        }
                    }
                        arrayOfData.InsertRange(indexOfElement, dividedWord);

                }
            }

            Console.WriteLine(string.Join(" ", arrayOfData));

        }
    }
}
