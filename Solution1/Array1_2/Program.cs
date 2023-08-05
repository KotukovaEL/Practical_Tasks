using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonArray;

namespace Array1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayHelpers.GenerateArray(25, -100, 100);
            PrintArray(array);
            Console.WriteLine();
            int number = WriteNumber();
            ArrayHelpers.ReplaceEvenElements(array, number);
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
    }
}
