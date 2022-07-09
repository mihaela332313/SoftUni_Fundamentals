using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Train
    {
        static void Main(string[] args)
        {
            List<int> passengersInWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxWagonCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                List<string> instructions = Console.ReadLine().Split().ToList();
                string comand = instructions[0];

                if (comand == "end")
                {
                    break;
                }

                if (instructions.Count == 1)
                {
                    int addNewPassengersInWagon = int.Parse(comand);

                    for (int wagon = 0; wagon < passengersInWagons.Count; wagon++)
                    {
                        if( passengersInWagons[wagon] + addNewPassengersInWagon <= maxWagonCapacity)
                        {
                            passengersInWagons[wagon] += addNewPassengersInWagon;
                            break;
                        }
                    }
                }

                if(comand == "Add")
                {
                    int newWagonWithPassengers = int.Parse(instructions[1]);
                    passengersInWagons.Add(newWagonWithPassengers);
                }


            }
            Console.WriteLine(string.Join(" ", passengersInWagons));

        }
    }
}
