using System;
using System.Linq;

namespace _10._LadyBugs
{
    class LadyBug
    {
        static void Main(string[] args)
        {

            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugFields = new int[fieldSize];
            string[] occupiedIndexes = Console.ReadLine().Split();

            for (int currIndex = 0; currIndex< occupiedIndexes.Length; currIndex++)
            {
                int currentIndex = int.Parse(occupiedIndexes[currIndex]);
                if(currentIndex>=0 && currentIndex< fieldSize)
                {
                    ladyBugFields[currentIndex] = 1;
                }
            }

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                bool isFirst = true;
                int ladyBugIndex = int.Parse(commands[0]);
                while (ladyBugIndex>=0 && ladyBugIndex< fieldSize && ladyBugFields[ladyBugIndex]!=0)
                {
                    if (isFirst)
                    {
                        ladyBugFields[ladyBugIndex] = 0;
                        isFirst = false;
                    }

                    string direction = commands[1];
                    int flightLenght = int.Parse(commands[2]);

                    if (direction == "left")
                    {
                        ladyBugIndex -= flightLenght;
                        if(ladyBugIndex>=0 && ladyBugIndex< fieldSize)
                        {
                            if(ladyBugFields[ladyBugIndex] == 0)
                            {
                                ladyBugFields[ladyBugIndex] = 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        ladyBugIndex += flightLenght;
                        if (ladyBugIndex >= 0 && ladyBugIndex < fieldSize)
                        {
                            if (ladyBugFields[ladyBugIndex] == 0)
                            {
                                ladyBugFields[ladyBugIndex] = 1;
                                break;
                            }
                        }
                    }
                }

                commands = Console.ReadLine().Split();

            }

            Console.WriteLine(string.Join(" ", ladyBugFields));
        }
    }
}
