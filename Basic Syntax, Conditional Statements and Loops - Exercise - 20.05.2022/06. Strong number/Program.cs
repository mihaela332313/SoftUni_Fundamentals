using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that receives a single integer and calculates if it's strong or not.
             * A number is strong, if the sum of the factorials of each digit is equal to the number itself.
            Example: 145 is a strong number, because 1! + 4! + 5! = 145. 
            Print "yes", if the number is strong and "no", if the number is not strong.
             */

            int number = int.Parse(Console.ReadLine()); //145
            int copyOfNumber = number; //145
            int sum = 0;

            while ( number >0)
            {
                int factorialNumber = 1;
                int currentNumber = number % 10; // 5
                number /= 10; // 14

                for ( int i = 2; i<= currentNumber; i++)
                {
                    factorialNumber *= i;
                }

                sum += factorialNumber;
            }
           
            Console.WriteLine(sum == copyOfNumber ? "yes" : "no");

            
        }

    }
}
