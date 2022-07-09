using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class HouseParty
    {
        static void Main(string[] args)
        {
            int numberOfComands = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int currentComand = 0; currentComand < numberOfComands; currentComand++)
            {
                List<string> instructions = Console.ReadLine().Split().ToList();
                string name = instructions[0];

                if (instructions.Count == 3)
                {
                    AddToGuestList(guestList, instructions, name);
                }
                else
                {
                    RemoveFromTheList(guestList, instructions, name);
                }

            }

            foreach(string guest in guestList)
            {
                Console.WriteLine(guest);
            }

        }

        static string AddToGuestList(List<string> guestList, List<string> commands, string name)
        {

            if (guestList.Contains(name))
            {
                Console.WriteLine($"{name} is already in the list!");
            }
            else
            {
                guestList.Add(name);
            }

            return name;
        }

        private static string RemoveFromTheList(List<string> guestList, List<string> instructions, string name)
        {
            if (instructions[2] == "not")
            {
                if (guestList.Contains(name))
                {
                    guestList.Remove(name);
                }
                else
                {
                    Console.WriteLine($"{name} is not in the list!");
                }
            }
            return name;
        }
    }
}
