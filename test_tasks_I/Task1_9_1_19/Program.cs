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
            double d = (b+Math.Sqrt(Math.Pow(b,2) + 4 * a * c)) / (2 * a) - Math.Pow(a,3) + Math.Pow(b,-2);
            Console.WriteLine("Ответ: " + d);
            Console.ReadLine();
        }

        static double ReadDouble(string str)
        {
            if (!double.TryParse(str, out double value))
            {
                throw new Exception($"Некорректное целое значение '{value}'.");
            }

            return value;
        }
    }
}
