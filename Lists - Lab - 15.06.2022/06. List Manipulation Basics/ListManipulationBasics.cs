using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class ListManipulationBasics
    {
        static void Main(string[] args)
        {
            List<int> consecutiveNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                List<string> indications = Console.ReadLine().Split().ToList();
                string command = indications[0];

                if (command =="end")
                {
                    break;
                }

                switch (command)
                {
                    case "Add":
                        consecutiveNumbers.Add(int.Parse(indications[1]));  
                        break;
                    case "Remove":
                        consecutiveNumbers.Remove(int.Parse(indications[1]));
                        break;
                    case "RemoveAt":
                        int currentIndex = int.Parse(indications[1]);
                        consecutiveNumbers.RemoveAt(currentIndex);
                        break;
                    case "Insert":
                        int number = int.Parse(indications[1]);
                        int index = int.Parse(indications[2]);
                        consecutiveNumbers.Insert(index, number);
                        break;
                }

            }

            Console.WriteLine(string.Join(" ", consecutiveNumbers));
        }
    }
}
