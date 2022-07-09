using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int numbers = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int currentNumber = 1; currentNumber <= numbers; currentNumber++)
            {
              
                sum += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
