using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = GenerateArray(25, -300, 300);
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
            array = array.Where(x => x % 2 != 0).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
