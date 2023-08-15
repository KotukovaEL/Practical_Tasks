using Methods;
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
            (double x1, double y1) = Class1.ReadPoint();

            Console.WriteLine("Введите координаты точки 2.");
            (double x2, double y2) = Class1.ReadPoint();

            Console.WriteLine("Введите координаты точки 3.");
            (double x3, double y3) = Class1.ReadPoint();

            double a = Class1.GetDistance_2(x1, y1, x2, y2);
            double b = Class1.GetDistance_2(x2, y2, x3, y3);
            double c = Class1.GetDistance_2(x1, y1, x3, y3);
            Console.WriteLine(Class1.EnsureTriangle_1(a, b, c));
        }        
    }
}
