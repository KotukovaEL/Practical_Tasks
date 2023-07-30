using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = GenerateArray(25, -100, 100);
            PrintArray(array);
            Console.WriteLine();
            RemoveElements(array);
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static int[] GenerateArray(int length, int minValue, int MaxValue)
        {
            int[] array = new int[length];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, MaxValue);
            }

            return array;
        }

        static void RemoveElements(int[] array)
        {
            Console.WriteLine("Чтобы удалить из массива элементы с номера k1 по номер к2, введите k1 и k2"); 
            int k1 = int.Parse(Console.ReadLine());
            int k2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < k1; i++)
            {
                Console.Write(array[i] + " ");
            }

            for (int j = k2 + 1; j < array.Length; j++)
            {
                Console.Write(array[j] + " ");
            }
        }
    }
}
