using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayHelpers;

namespace Array1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayHelpers.ArrayHelpers.GenerateArray(25, -300, 300);
            PrintArray(array);
            Console.WriteLine();
            int number = WriteNumber();
            ReplaceElements(array, number);
            PrintArray(array);
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        private static int WriteNumber()
        {
            Console.WriteLine("Введите любое число: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static void ReplaceElements(int[] array, int number)
        {            
            for (int i = 0; i < array.Length; i++)
            {
                int abs = Math.Abs(array[i]);
                if (abs >= 10 && abs <= 99)
                {
                    array[i] = number;
                }
            }
        }
    }
}
