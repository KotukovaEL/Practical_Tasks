﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_9_1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x");
            double x = ReadDouble(Console.ReadLine());
            double y = 1 + (x / 3) + Math.Abs(x) + ((x * x * x + 4) / 2);
            Console.WriteLine("Ответ: " + y);
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
