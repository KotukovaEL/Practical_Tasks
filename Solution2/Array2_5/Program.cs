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
            int k1 = PrintK1();
            int k2 = PrintK2();
            int[] newArray = RemoveElements(array, k1, k2);
            PrintArray(newArray);
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        private static int PrintK1()
        {
            Console.WriteLine("Чтобы удалить из массива элементы с номера k1 по номер к2, введите k1 и k2");
            int k1 = int.Parse(Console.ReadLine());
            return k1;
        }

        private static int PrintK2()
        {
            int k2 = int.Parse(Console.ReadLine());
            return k2;
        }

        static int[] RemoveElements(int[] array, int k1, int k2)
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

            return newArray;
        }
    }
}
