using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_9_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите периметр треугольника: ");
            double p = ReadDouble(Console.ReadLine());
            double s = (p * p * Math.Sqrt(3)) / 36;           
            Console.WriteLine("Периметр квадрата: " + s);            
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
