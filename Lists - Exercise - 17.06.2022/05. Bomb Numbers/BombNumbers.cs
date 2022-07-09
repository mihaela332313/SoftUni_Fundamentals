using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> numberSequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> specialNumberWithPower = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bombNumber =specialNumberWithPower[0];
            int numsToBeRemoved = specialNumberWithPower[1];


            for (int currentIndex = 0; currentIndex < numberSequence.Count; currentIndex++)
            {
                if (numberSequence[currentIndex] == bombNumber)
                {
                    int actionIndex = (currentIndex); 
                    int detonationStart = actionIndex - numsToBeRemoved; 
                    int detonationEnd = actionIndex + numsToBeRemoved;        

                    for ( int index = detonationStart; index <= detonationEnd;index++ )
                    {
                        if (index < numberSequence.Count && index >= 0)
                        {
                            numberSequence.Remove(numberSequence[index]);
                            numberSequence.Insert(index, 0);
                        }
                            
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numberSequence.Where(eachNum => eachNum != 0).Sum()));
        }  
    }
}
