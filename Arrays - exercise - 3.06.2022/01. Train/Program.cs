using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfWagons = int.Parse(Console.ReadLine());
            int[] wagons = new int[numOfWagons];
            int sum = 0;

            for (int currentWagon = 0; currentWagon < wagons.Length; currentWagon++)
            {
                wagons[currentWagon] = int.Parse(Console.ReadLine());
                sum += wagons[currentWagon];
            }

            foreach (int wagon in wagons)
            {
                Console.Write($"{wagon} ");
            }

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
