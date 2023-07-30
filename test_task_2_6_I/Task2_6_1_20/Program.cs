using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_6_1_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<(double x, double y)> points = new List<(double x, double y)>();

            Console.WriteLine("Введите координаты точки 1.");
            points.Add(ReadPoint());

            Console.WriteLine("Введите координаты точки 2.");
            points.Add(ReadPoint());

            Console.WriteLine("Введите координаты точки 3.");
            points.Add(ReadPoint());

            Console.WriteLine("Введите координаты точки 4.");
            points.Add(ReadPoint());


            Console.WriteLine(FindNumberOfTriangles(points));
        }

        static (double x, double y) ReadPoint()
        {
            Console.WriteLine("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            double y = double.Parse(Console.ReadLine());

            return (x, y);
        }

        static double GetDistance((double x, double y) point1, (double x, double y) point2)
        {
            return Math.Sqrt((point2.x - point1.x) * (point2.x - point1.x) + (point2.y - point1.y) * (point2.y - point1.y));
        }

        static bool EnsureTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        static int FindNumberOfTriangles(List<(double x, double y)> points)
        {
            int count = 0;

            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    if (i == j)
                    { 
                        continue;
                    }

                    for(int k = j + 1; k < points.Count; k++)
                    {
                        if (i == k || j == k)
                        {
                            continue;
                        }

                        double a = GetDistance(points[i], points[j]);
                        double b = GetDistance(points[j], points[k]);
                        double c = GetDistance(points[k], points[i]);
                        if (EnsureTriangle(a, b, c))
                        {
                            ++count;
                        }
                    }
                }
            }
            return count;
        }
    }
}
