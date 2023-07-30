using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_6_1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(Metod(x));
        }

        static int Metod(int x)
        {
            if (x % 2 == 0)
            {
                x = x / 2;
                return x;
            }
            else
            {
                x = 0;
                return x;
            }
        }
    }
}

