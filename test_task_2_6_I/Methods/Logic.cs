using System;
using System.Collections.Generic;

namespace Methods
{
    public class Logic
    {
        public static double FindMin_for_Task_2_6_1_2(double x, double y, double z, double v)
        {
            return Math.Min(Math.Min(x, y), Math.Min(z, v));
        }

        public static double ReadDouble(string str)
        {
            if (!double.TryParse(str, out double value))
            {
                throw new Exception($"Некорректное целое значение '{str}'.");
            }

            return value;
        }

        public static double FindMin_for_Task2_6_1_1(double x, double y)
        {
            return (Math.Min(3 * x, 2 * y) + Math.Min(x - y, x + y));
        }

        public static int ReplacesOddNumberWith0(int x)
        {
            if (x % 2 == 0)
            {
                x = x / 2;           
            }
            else
            {
                x = 0;
            }
            return x;
        }

        public static (double x, double y) ReadPoint()
        {
            Console.WriteLine("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            double y = double.Parse(Console.ReadLine());

            return (x, y);
        }

        private static double GetDistance((double x, double y) point1, (double x, double y) point2)
        {
            return Math.Sqrt((point2.x - point1.x) * (point2.x - point1.x) + (point2.y - point1.y) * (point2.y - point1.y));
        }

        public static string EnsureTriangle(double a, double b, double c)
        {
            if (ISTriangle(a, b, c))
            {
                return "Треугольник существует";
            }
            else
            {
                return "Треугольник не существует";
            }
        }

        public static int FindNumberOfTriangles(List<(double x, double y)> points)
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

                    for (int k = j + 1; k < points.Count; k++)
                    {
                        if (i == k || j == k)
                        {
                            continue;
                        }

                        double a = GetDistance(points[i], points[j]);
                        double b = GetDistance(points[j], points[k]);
                        double c = GetDistance(points[k], points[i]);
                        if (ISTriangle(a, b, c))
                        {
                            ++count;
                        }
                    }
                }
            }
            return count;
        }

        public static bool ISTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        public static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }
    }
}
