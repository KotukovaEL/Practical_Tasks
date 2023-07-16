using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_9_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите площадь квадрата: ");
            double s = ReadDouble(Console.ReadLine());
            double p = 4 * Math.Sqrt(s);
            Console.WriteLine("Периметр квадрата: " + p);
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
