using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_9_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x");
            double x = ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            double y = ReadDouble(Console.ReadLine());
            double z = (Math.Pow(Math.E, -x)) - (Math.Cos(x)) + Math.Sin(2 * x * y);
            Console.WriteLine("Ответ: " + z);
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
