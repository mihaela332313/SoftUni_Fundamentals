using System;

namespace _07._Repeat_String
{
    class repeatString
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int repetitions = int.Parse(Console.ReadLine());
            Console.WriteLine(ConnectedCommand(command, repetitions));
        }

        static string ConnectedCommand(string command, int repetitions)
        {
            string results = "";
            for (int currRepetition = 1; currRepetition <= repetitions; currRepetition++)
            {
                results += command;
            }
            return results;
        }
    }
}
