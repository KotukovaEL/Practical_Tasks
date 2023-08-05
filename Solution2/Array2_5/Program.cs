using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonArray;

namespace Array2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayHelpers.GenerateArray(25, -100, 100);
            PrintArray(array);
            Console.WriteLine();
            int k1 = EnterNumber("k1");
            int k2 = EnterNumber("k2");
            Validate(array.Length, k1, k2);
            ArrayHelpers.RemoveElementsFromK1ToK2(ref array, k1, k2);
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
    }
}
