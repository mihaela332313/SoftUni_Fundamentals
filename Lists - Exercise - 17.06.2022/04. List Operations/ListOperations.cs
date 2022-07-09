using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class ListOperations
    {
        static void Main(string[] args)
        {
            List<int> integerList = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                List<string> instructions = Console.ReadLine().Split().ToList();
                string comand = instructions[0];

                if (comand == "End")
                {
                    break;
                }

                if (comand == "Add")
                {
                    int number = int.Parse(instructions[1]);
                    integerList.Add(number);
                }
                else if (comand == "Insert")
                {
                    int number = int.Parse(instructions[1]);
                    int position = int.Parse(instructions[2]);

                    if (position <= integerList.Count && position >= 0)
                    {
                        integerList.Insert(position, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                }
                else if (comand == "Remove")
                {

                    int index = int.Parse(instructions[1]);
                    if (index <= integerList.Count && index >=0)
                    {
                        integerList.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                }
                else if (comand == "Shift")
                {
                    string direction = instructions[1];
                    int count = int.Parse(instructions[2]);

                    if(direction == "left")
                    {
                        for (int currentIndex = 0; currentIndex<count; currentIndex++)
                        {
                            integerList.Add(integerList[0]);
                            integerList.RemoveAt(0);
                        }
                    }
                    else
                    {
                        for (int currentIndex = 0; currentIndex < count; currentIndex++)
                        {
                            integerList.Insert(0, integerList[integerList.Count - 1]);
                            integerList.RemoveAt(integerList.Count-1);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", integerList));

        }
    }
}
