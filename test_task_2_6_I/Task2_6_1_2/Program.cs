using System;
using Methods;

namespace Task2_6_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x: ");
            double x = Logic.ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            double y = Logic.ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите значение z: ");
            double z = Logic.ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите значение v: ");
            double v = Logic.ReadDouble(Console.ReadLine());
            Console.WriteLine(Logic.FindMin_for_Task_2_6_1_2(x, y, z, v));
        }
    }
}

