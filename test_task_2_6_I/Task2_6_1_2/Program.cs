using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_6_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x: ");
            double x = ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            double y = ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите значение z: ");
            double z = ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите значение v: ");
            double v = ReadDouble(Console.ReadLine());
            Console.WriteLine(MetodMin(x, y, z, v));
        }

        static double MetodMin(double x, double y, double z, double v)
        {
            return (Math.Min(Math.Min(x, y), Math.Min(z, v)));
        }

        static double ReadDouble(string str)
        {
            if (!double.TryParse(str, out double value))
            {
                throw new Exception($"Некорректное целое значение '{str}'.");
            }

            return value;
        }
    }
}

