using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class GaussTrick
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            int initialLenght = numbers.Count;

            for (int currentIndex = 0; currentIndex< initialLenght/2 ; currentIndex++)
            {
                numbers[currentIndex] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
