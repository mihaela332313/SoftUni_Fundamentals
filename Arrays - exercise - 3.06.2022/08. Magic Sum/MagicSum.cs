using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class MagicSum
    {
        static void Main(string[] args)
        {
            

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int givenNumber = int.Parse(Console.ReadLine()); // 8
 
            for (int currentNumber = 0; currentNumber<array.Length-1; currentNumber++) // 1
            {
                for ( int nextNumber = currentNumber+1; nextNumber< array.Length; nextNumber++) // 7
                {
                    if(array[currentNumber] + array[nextNumber] == givenNumber)
                    {
                        Console.Write($"{array[currentNumber]} {array[nextNumber]}");
                        Console.WriteLine();
                    }
                }
            }

        }
    } 

}
