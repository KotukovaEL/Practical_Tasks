using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayHelpers;

namespace Array1_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayHelpers.ArrayHelpers.GenerateArray(25, -300, 300);
            PrintArray(array);
            Console.WriteLine();
            RearrangElements(array);
            PrintArray(array);
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }       

        static void RearrangElements(int[] array)
        {
            Array.Reverse(array);
        }
    }
}

