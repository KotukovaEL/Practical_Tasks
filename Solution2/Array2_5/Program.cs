using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayHelpers;

namespace Array2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayHelpers.ArrayHelpers.GenerateArray(25, -100, 100);
            PrintArray(array);
            Console.WriteLine();
            int k1 = EnterNumber("k1");
            int k2 = EnterNumber("k2");
            Validate(array.Length, k1, k2);
            RemoveElements(ref array, k1, k2);
            PrintArray(array);
        }

        private static void Validate(int length, int k1, int k2)
        {
            if (k1 < 0 || k1 > k2 || k2 >= length)
            {
                throw new Exception("Ошибка");
            }
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        private static int EnterNumber(string paramName)
        {
            Console.WriteLine($"Введите {paramName} ");
            return int.Parse(Console.ReadLine());            
        }

        static void RemoveElements(ref int[] array, int k1, int k2)
        {
            int[] newArray = new int[array.Length - k1 - k2 - 1];
            int newIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i < k1 || i > k2)
                {
                    newArray[newIndex] = array[i];
                    newIndex++;
                }
            }
            array = newArray;
        }
    }
}
