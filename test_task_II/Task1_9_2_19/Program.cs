using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_9_2_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый член арифметической прогрессии: ");
            double a = ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите разность между элементами арифметической прогрессии: ");
            double d = ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите число членов арифметической прогрессии: ");
            double n = ReadDouble(Console.ReadLine());
            double sum = (2 * a + d * (n - 1)) / 2 * n;
            Console.WriteLine("Сумма арифметической прогрессии: " + sum);
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
