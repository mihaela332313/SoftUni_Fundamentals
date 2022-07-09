using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced


{
    class ListManipulationBasics
    {
        static void Main(string[] args)
        {
            List<int> consecutiveNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool isListManipulated = false;

            while (true)
            {
                List<string> indications = Console.ReadLine().Split().ToList();
                string command = indications[0];

                if (command == "end")
                {
                    break;
                }

                switch (command)
                {
                    case "Add":
                        consecutiveNumbers.Add(int.Parse(indications[1]));
                        isListManipulated = true;
                        break;
                    case "Remove":
                        consecutiveNumbers.Remove(int.Parse(indications[1]));
                        isListManipulated = true;
                        break;
                    case "RemoveAt":
                        int currentIndex = int.Parse(indications[1]);
                        consecutiveNumbers.RemoveAt(currentIndex);
                        isListManipulated = true;
                        break;
                    case "Insert":
                        int number = int.Parse(indications[1]);
                        int index = int.Parse(indications[2]);
                        consecutiveNumbers.Insert(index, number);
                        isListManipulated = true;
                        break;
                    case "Contains":
                        CheckContains(int.Parse(indications[1]), consecutiveNumbers);
                        break;
                    case "PrintEven":
                        PrintEven(consecutiveNumbers);
                        break;
                    case "PrintOdd":
                        PrintOdd(consecutiveNumbers);
                        break;
                    case "GetSum":
                        int sum = GetSum(consecutiveNumbers);
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        PrintFiltered(indications[1], int.Parse(indications[2]), consecutiveNumbers);
                        break;
                }

            }

            if (isListManipulated)
            {
                Console.WriteLine(string.Join(" ", consecutiveNumbers));
            }
        }
        private static void CheckContains(int number, List<int> consecutiveNumbers)
        {
            if (consecutiveNumbers.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
        private static void PrintEven(List<int> consecutiveNumbers)
        {
            foreach (int number in consecutiveNumbers)
            {
                if(number % 2 == 0)
                {
                    Console.Write($"{number} ");
                }
            }
            Console.WriteLine();
        }
        private static void PrintOdd(List<int> consecutiveNumbers)
        {
            foreach (int number in consecutiveNumbers)
            {
                if (number % 2 != 0)
                {
                    Console.Write($"{number} ");
                }
            }
            Console.WriteLine();
        }
        private static int GetSum(List<int> consecutiveNumbers)
        {
            int sum = 0;
            foreach(int number in consecutiveNumbers)
            {
                sum += number;
            }
            return sum;
        }

        private static void PrintFiltered(string filter, int numberToFilter, List<int> consecutiveNumbers)
        {
            switch(filter)
            {
                case "<":
                    foreach (int number in consecutiveNumbers)
                    {
                        if (number < numberToFilter)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case "<=":
                    foreach (int number in consecutiveNumbers)
                    {
                        if (number <= numberToFilter)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case ">":
                    foreach (int number in consecutiveNumbers)
                    {
                        if (number > numberToFilter)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case ">=":
                    foreach (int number in consecutiveNumbers)
                    {
                        if (number >= numberToFilter)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                    break;
            }
        }

    }
}
