using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double ticketPrice = 0;

            switch (dayOfWeek)
            {
                case "Weekday":
                    if (0 <= age && age <= 18 || 64 < age && age <= 122)
                    {
                        ticketPrice = 12;
                        Console.WriteLine($"{ticketPrice}$");

                    }
                    else if (18 < age && age <= 64)
                    {
                        ticketPrice = 18;
                        Console.WriteLine($"{ticketPrice}$");

                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Weekend":
                    if (0 <= age && age <= 18 || 64 < age && age <= 122)
                    {
                        ticketPrice = 15;
                        Console.WriteLine($"{ticketPrice}$");

                    }
                    else if (18 < age && age <= 64)
                    {
                        ticketPrice = 20;
                        Console.WriteLine($"{ticketPrice}$");

                    }
                    else
                    {
                        Console.WriteLine("Error!");

                    }                  
                    break;
                case "Holiday":
                    if (0 <= age && age <= 18)
                    {
                        ticketPrice = 5;
                        Console.WriteLine($"{ticketPrice}$");

                    }
                    else if (18 < age && age <= 64)
                    {
                        ticketPrice = 12;
                        Console.WriteLine($"{ticketPrice}$");

                    }
                    else if (64 < age && age <= 122)
                    {
                        ticketPrice = 10;
                        Console.WriteLine($"{ticketPrice}$");

                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;

            }
        }
    }
}
