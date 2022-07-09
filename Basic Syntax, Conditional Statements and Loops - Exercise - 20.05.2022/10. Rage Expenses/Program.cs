using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadsetCounter = 0;
            int trashedMouseCounter = 0;
            int trashedKeyboardCounter = 0;
            int trashedDisplayCounter = 0;

            for (int currentLostGame = 1; currentLostGame <= lostGames; currentLostGame++)
            {
                if (currentLostGame % 2 == 0)
                {
                    trashedHeadsetCounter++;
                }
                if (currentLostGame % 3 == 0)
                {
                    trashedMouseCounter++;
                }
                if (currentLostGame % 2 == 0 && currentLostGame % 3 == 0)
                {
                    trashedKeyboardCounter++;

                    if (trashedKeyboardCounter % 2 == 0)
                    {
                        trashedDisplayCounter++;
                    }
                }
            }
            double expenses = trashedHeadsetCounter * headsetPrice + trashedMouseCounter * mousePrice +
                trashedKeyboardCounter * keyboardPrice + trashedDisplayCounter * displayPrice;
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
