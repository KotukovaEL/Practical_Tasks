using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_9_2_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите объем куба: ");
            double v = ReadDouble(Console.ReadLine());
            double a =  Math.Pow(v, 1.0/3.0);
            Console.WriteLine("Pебро куба: " + a);
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
