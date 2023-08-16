using Methods;
using System;
using System.Collections.Generic;

namespace Task2_6_1_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<(double x, double y)> points = new List<(double x, double y)>();

            Console.WriteLine("Введите координаты точки 1.");
            points.Add(Logic.ReadPoint());

            Console.WriteLine("Введите координаты точки 2.");
            points.Add(Logic.ReadPoint());

            Console.WriteLine("Введите координаты точки 3.");
            points.Add(Logic.ReadPoint());

            Console.WriteLine("Введите координаты точки 4.");
            points.Add(Logic.ReadPoint());


            Console.WriteLine(Logic.FindNumberOfTriangles(points));
        }
    }
}
