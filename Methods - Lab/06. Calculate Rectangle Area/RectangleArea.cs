﻿using System;

namespace _05._Orders
{
    class Orders
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = GetRectangleArea(width, height);
            Console.WriteLine(area);

        }

        static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}