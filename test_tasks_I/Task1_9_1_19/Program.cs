using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_9_1_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение a");
            double a = ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            double b = ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите значение c");
            double c = ReadDouble(Console.ReadLine());
            double d = (b+Math.Sqrt(b * b + 4 * a * c)) / (2 * a) - a * a * a + (1 / (b * b));
            Console.WriteLine("Ответ: " + d);
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
