using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numOfOrders = int.Parse(Console.ReadLine());
            double price = 0;
            double totalPrice = 0;

            for( int currentOrder = 1; currentOrder <= numOfOrders; currentOrder++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int numOfCapsules = int.Parse(Console.ReadLine());

                price = numOfCapsules * days * capsulePrice;
                totalPrice += price;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
