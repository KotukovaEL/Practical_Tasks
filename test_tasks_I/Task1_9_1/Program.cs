using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1_9_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x");
            double x = ReadDouble(Console.ReadLine());
            double y = 10 * (Math.Sin(x)) + Math.Abs(Math.Pow(x, 4) - Math.Pow(x, 5));
            Console.WriteLine("Ответ: " + y);
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
