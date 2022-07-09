using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine()); //1
            int mins = int.Parse(Console.ReadLine()); //46


            if ((mins + 30) >= 60)
            {
                hour++; //2
                mins = mins - 60;
            }
            if (hour == 24)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{mins + 30:d2}");

        }
    }
}
