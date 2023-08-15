using System;
using Methods;

namespace Task2_6_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x: ");
            double x = Class1.ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            double y = Class1.ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите значение z: ");
            double z = Class1.ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите значение v: ");
            double v = Class1.ReadDouble(Console.ReadLine());
            Console.WriteLine(Class1.FindMin_1(x, y, z, v));
        }
    }
}

