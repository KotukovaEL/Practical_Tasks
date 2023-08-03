using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayHelpers;

namespace Array2_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayHelpers.ArrayHelpers.GenerateArray(25, -100, 100);
            PrintArray(array);
            int number = PrintNumber();
            int digit = PrintDigit();
            int count = CountDigit(array, digit);
            Console.WriteLine();
            int[] newArray = InsertNewElementInFrontAllElementsThatHaveDigitInTheirRecords(array, number, digit, count);
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

        private static int CountDigit(int[] array, int digit)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].ToString().Contains(digit.ToString()))
                {
                    count++;
                }
            }

            return count;
        }
        static int[] InsertNewElementInFrontAllElementsThatHaveDigitInTheirRecords(int[] array, int number, int digit, int count)
        {
            int[] array2 = new int[array.Length + count];
            int newInd = 0;

            for(int i = 0 ; i < array.Length ; i++)
            {
                if (array[i].ToString().Contains(digit.ToString()))
                {
                    array2[newInd] = number;
                    newInd++;
                }

                array2[newInd] = array[i];
                newInd++;
            }

            return array2;
        }
    }
}