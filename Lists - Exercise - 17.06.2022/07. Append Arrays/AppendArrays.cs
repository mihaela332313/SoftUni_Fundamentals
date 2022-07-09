using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class AppendArrays
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine().Split('|').Reverse().ToList();

            List<int> reversedArray = new List<int>();

            foreach(var number in array)
            {
                reversedArray.AddRange(number.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(string.Join(" ", reversedArray));

        }
    }
}
