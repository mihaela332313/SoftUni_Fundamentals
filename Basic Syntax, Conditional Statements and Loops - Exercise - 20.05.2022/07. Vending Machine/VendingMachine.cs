using System;

namespace _07._Vending_Machine
{
    class VendingMachine
    {
        static void Main(string[] args)
        {
            //Write a program that accumulates coins. Until the "Start" command is given, you will receive coins,
            //and only the valid ones should be accumulated. 0.1, 0.2, 0.5, 1 and 2

            string command = Console.ReadLine();

            double moneyAccumulated = 0;

            while ( command != "Start")
            {
                double coins = double.Parse(command);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    moneyAccumulated += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                command = Console.ReadLine();

            }
            command = Console.ReadLine();
            double totalPrice = 0;

                //            "Nuts" with a price of 2.0
                //"Water" with a price of 0.7
                //"Crisps" with a price of 1.5
                //"Soda" with a price of 0.8
                //"Coke" with a price of 1.0

            while (command != "End")
            {
                switch (command)
                {
                    case "Nuts":
                        totalPrice = 2;
                        break;
                    case "Water":
                        totalPrice = 0.7;
                        break;
                    case "Crisps":
                        totalPrice = 1.5;
                        break;
                    case "Soda":
                        totalPrice = 0.8;
                        break;
                    case "Coke":
                        totalPrice = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        command = Console.ReadLine();
                        continue;
                }

                if (totalPrice <= moneyAccumulated)
                {
                    moneyAccumulated -= totalPrice;
                    Console.WriteLine($"Purchased {command.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {moneyAccumulated:f2}");
        }
    }
}
