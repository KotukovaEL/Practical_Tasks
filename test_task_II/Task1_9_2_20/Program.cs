using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_9_2_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый член геометрической прогрессии: ");
            double b = ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите знаменатель геометрической прогрессии: ");
            double q = ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите число членов геометрической прогрессии: ");
            double n = ReadDouble(Console.ReadLine());
            double sum = b * ((Math.Pow(q, n) - 1) / (q - 1));
            Console.WriteLine("Сумма прогрессии: " + sum);
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
