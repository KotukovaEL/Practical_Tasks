using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_6_1_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки 1.");
            (double x1, double y1) = ReadPoint();

            Console.WriteLine("Введите координаты точки 2.");
            (double x2, double y2) = ReadPoint();

            Console.WriteLine("Введите координаты точки 3.");
            (double x3, double y3) = ReadPoint();

            double a = GetDistance(x1, y1, x2, y2);
            double b = GetDistance(x2, y2, x3, y3);
            double c = GetDistance(x1, y1, x3, y3);
            Console.WriteLine(EnsureTriangle(a, b, c));
        }

        static (double x, double y) ReadPoint()
        {
            Console.WriteLine("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            double y = double.Parse(Console.ReadLine());

            return (x, y);
        }

        static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));    
        }

        static string EnsureTriangle(double a, double b, double c)
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                return "Треугольник существует";
            }
            else
            {
                return "Треугольник не существует";
            }
        }
    }
}
