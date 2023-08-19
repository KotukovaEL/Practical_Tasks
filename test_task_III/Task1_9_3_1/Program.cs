using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_9_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое вещественное число: ");
            double a = ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите второе вещественное число: ");
            double b = ReadDouble(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Максимальное значение " + a);
            }
            else 
            {
                Console.WriteLine("Максимальное значение " + b);
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
