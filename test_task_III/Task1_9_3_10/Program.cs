using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_9_3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число: ");
            int a = ReadInt(Console.ReadLine());
            int abs = Math.Abs(a);

            if (abs < 10 || abs >= 100)
            {
                throw new Exception($"Число '{a}' - недвузначное ");
            }

            int b = a % 10;
            int c = a / 10;
            int d = b + c;

            if (d % 2 == 0)
            {
                Console.WriteLine("Сумма цифр двузначного числа четная");
            }
            else
            {
                Console.WriteLine("Сумма цифр двузначного числа нечетная");
            }
        }

        private static int ReadInt(string str)
        {
            if (!int.TryParse(str, out int value))
            {
                throw new Exception($"Некорректное целое значение '{str}'.");
            }

            return value;
        }
    }
}
