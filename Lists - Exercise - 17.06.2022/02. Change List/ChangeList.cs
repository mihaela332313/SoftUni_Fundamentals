using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> integerList = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                List<string> instructions = Console.ReadLine().Split().ToList();
                string comand = instructions[0];

                if (comand == "end")
                {
                    break;
                }

                int number = int.Parse(instructions[1]);

                if (comand == "Delete")
                {
                    integerList.RemoveAll(eachNum => eachNum == number);
                }
                else
                {
                    int position = int.Parse(instructions[2]);

                    if (position <= integerList.Count)
                    {
                        integerList.Insert(position, number);
                    }
                }


            }

            Console.WriteLine(string.Join(" ", integerList));

        }
    }
}
