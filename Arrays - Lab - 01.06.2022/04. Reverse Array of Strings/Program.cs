using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split().ToArray(); // a b c d e  - e d c b a

            for (int elementIndex = 0; elementIndex < elements.Length / 2; elementIndex++) //2
            {
                string oldElement = elements[elementIndex]; // 0 - 0 (a) .. 1 -b 

                elements[elementIndex] = elements[elements.Length - 1 - elementIndex]; // 5 - 1 - 0 = e .. 3 = d
                elements[elements.Length - 1 - elementIndex] = oldElement;

            }
            Console.WriteLine(string.Join(" ", elements));


        }
    }
}
