using System;

namespace _11._Math_operations
{
    class MathOperations
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(OperationBetweenNumbers(firstNumber, operation, secondNumber));
        }

        static double OperationBetweenNumbers(int firstNumber, string operation, int secondNumber)
        {
            double result = 0;
            switch (operation)
            {
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "+":
                    result = firstNumber + secondNumber;
                    break;
            }
            return result;
        }
    }
}
