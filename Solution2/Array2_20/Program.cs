using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonArray;

namespace Array2_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayHelpers.GenerateArray(25, -100, 100);
            PrintArray(array);
            int number = PrintNumber();
            int digit = PrintDigit();
            int countMax = ArrayHelpers.CountDigit(array, digit);
            Console.WriteLine();
            int[] newArray = ArrayHelpers.InsertBeforeElementsWithDigit(array, number, digit, countMax);
            PrintArray(newArray);
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        private static int PrintNumber()
        {
            Console.WriteLine("\nВведите число: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        private static int PrintDigit()
        {
            Console.WriteLine("\nВведите цифру: ");
            int digit = int.Parse(Console.ReadLine());
            return digit;
        }
    }
}