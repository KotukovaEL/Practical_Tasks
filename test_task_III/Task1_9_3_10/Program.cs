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
            if (Math.Abs(a) >= 10 && Math.Abs(a) < 100 || -Math.Abs(a) >= -10 && -Math.Abs(a) > 100)
            {
                int b = a % 10;
                int c = a / 10;
                int d = b + c;
                if (d % 2 == 0)
                {
                    Console.WriteLine("Сумма цифр двухзначного числа четная");
                }
                
                else 
                {
                    Console.WriteLine("Сумма цифр двухзначного числа нечетная");
                }
            }
            Console.ReadLine();
        }

        private static int ReadInt(string str)
        {
            if (!int.TryParse(str, out int value))
            {
                throw new Exception($"Некорректное целое значение '{value}'.");
            }

            return value;
        }
    }
}
