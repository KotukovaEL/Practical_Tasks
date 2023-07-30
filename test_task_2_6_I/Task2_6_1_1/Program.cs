using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_6_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x: ");
            double x = ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            double y = ReadDouble(Console.ReadLine());
            Console.WriteLine(Metod(x, y));
        }

        static double Metod(double x, double y)
        {
            return (Math.Min(3 * x, 2 * y) + Math.Min(x - y, x + y));
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

