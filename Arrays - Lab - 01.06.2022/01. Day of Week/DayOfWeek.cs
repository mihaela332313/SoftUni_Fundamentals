using System;

namespace _01._Day_of_Week
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            int dayOfTheWeek = int.Parse(Console.ReadLine());

            string[] days = { 
                "Monday", 
                "Tuesday", 
                "Wednesday", 
                "Thursday", 
                "Friday", 
                "Saturday", 
                "Sunday" 
            };

            if (dayOfTheWeek >=1 && dayOfTheWeek <=7)
            {
                Console.WriteLine(days[dayOfTheWeek-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}


