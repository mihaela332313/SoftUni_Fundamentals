using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int multiplier = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"{multiplier} X {times} = {multiplier * times}");
                times++;
            }
            while (times <= 10);


        }
    }
}
