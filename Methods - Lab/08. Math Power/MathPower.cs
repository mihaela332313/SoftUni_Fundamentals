using System;

namespace _08._Math_Power
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int degree = int.Parse(Console.ReadLine());
            Console.WriteLine(Power(number, degree));
        }

        private static double  Power( double number,  int degree)
        {
            double results = Math.Pow(number, degree);
            return results;
        }
    }
}
