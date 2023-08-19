using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_9_3_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону треугольника: ");
            double a = ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону треугольника: ");
            double b = ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите третью сторону треугольника: ");
            double c = ReadDouble(Console.ReadLine());

            if (a + b <= c || a + c <= b || c + b <= a)
            {
                throw new Exception("Такого треугольника не существует");
            }

            if (a == b && a == c && b == c)
            {
                Console.WriteLine("Треугольник равносторонний");
            }
            else
            {
                Console.WriteLine("Треугольник неравносторонний ");
            }
        }

        private static double ReadDouble(string str)
        {
            if (!double.TryParse(str, out double value))
            {
                throw new Exception($"Некорректное целое значение '{str}'.");
            }

            return value;
        }
    }
}
