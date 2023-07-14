using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_9_1_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x");
            double x = ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            double y = ReadDouble(Console.ReadLine());
            double c = Math.Log(Math.Abs(y - Math.Sqrt(Math.Abs(x)) * (x - (y / (x + Math.Pow(x,2) / 4)))));
            Console.WriteLine("Ответ: " + c);
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
