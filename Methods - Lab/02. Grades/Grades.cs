using System;

namespace _02._Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            PrintGradeDefinition(grade);
        }

        static void PrintGradeDefinition(double grade)
        {
            bool fail = grade >= 2 && grade <= 2.99;
            bool poor = grade >= 3 && grade <= 3.49;
            bool good = grade >= 3.50 && grade <= 4.49;
            bool veryGoog = grade >= 4.50 && grade <= 5.49;
            bool excellent = grade >= 5.50;

            if (fail)
            {
                Console.WriteLine("Fail");
            }
            else if (poor)
            {
                Console.WriteLine("Poor");
            }
            else if (good)
            {
                Console.WriteLine("Good");
            }
            else if (veryGoog)
            {
                Console.WriteLine("Very Good");
            }
            else
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
