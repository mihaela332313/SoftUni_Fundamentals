using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class ListOfProducts
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            List<string> productsList = new List<string>();

            for(int currentIndex = 0; currentIndex< numberOfProducts; currentIndex++)
            {
                string productName = Console.ReadLine();
                productsList.Add(productName);
            }

            productsList.Sort();

            for (int currentIndex = 0; currentIndex< productsList.Count; currentIndex++)
            {
                Console.WriteLine($"{currentIndex+1}.{productsList[currentIndex]}");
            }
        }
    }
}
