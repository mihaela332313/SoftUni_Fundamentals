using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {

            int numOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double priceForGroup = 0;

            switch (typeOfGroup)
            {
                case "Students":
                    switch(dayOfTheWeek)
                    {
                        case "Friday":
                            priceForGroup = numOfPeople * 8.45;
                            break;
                        case "Saturday":
                            priceForGroup = numOfPeople * 9.8;
                            break;
                        case "Sunday":
                            priceForGroup = numOfPeople * 10.46;
                            break;                           
                    }
                    if (numOfPeople >= 30)
                    {
                        priceForGroup *= 0.85;
                    }
                    break;

                case "Business":
                    switch (dayOfTheWeek)
                    {
                        case "Friday":
                            priceForGroup = numOfPeople * 10.9;
                            break;
                        case "Saturday":
                            priceForGroup = numOfPeople * 15.6;
                            break;
                        case "Sunday":
                            priceForGroup = numOfPeople * 16.00;//1760
                            break;
                    }
                    if (numOfPeople >= 100)//110
                    {
                        priceForGroup -= priceForGroup / numOfPeople * 10; //1760 -= 1760 / 110*10
                    }                   
                    break;

                case "Regular":
                    switch (dayOfTheWeek)
                    {
                        case "Friday":
                            priceForGroup = numOfPeople * 15;
                            break;
                        case "Saturday":
                            priceForGroup = numOfPeople * 20;
                            break;
                        case "Sunday":
                            priceForGroup = numOfPeople * 22.5;
                            break;
                    }
                    if (numOfPeople >=10 && numOfPeople <= 20)
                    {
                        priceForGroup *= 0.95;
                    }                  
                    break;

            }
            Console.WriteLine($"Total price: {priceForGroup:f2}");


        }
    }
}
