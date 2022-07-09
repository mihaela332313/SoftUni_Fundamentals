using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(age <= 2 ? "baby" :
                age > 2 && age <= 13 ? "child" :
                age > 13 && age <= 19 ? "teenager" :
                age > 19 && age <= 65 ? "adult"
                : "elder");

        }
    }
}
