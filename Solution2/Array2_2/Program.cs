using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayHelpers;

namespace Array2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayHelpers.ArrayHelpers.GenerateArray(25, -10, 10);
            PrintArray(array);
            Console.WriteLine();
            int maxNumber = ArrayHelpers.ArrayHelpers.FindMax(array);
            int numberOfMaximumNumbers = ArrayHelpers.ArrayHelpers.FindNumberOfMaximumNumbers(array, maxNumber);
            int[] newArray = RemoveMaximumNumbers(array, maxNumber, numberOfMaximumNumbers);
            PrintArray(newArray);
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static int[] RemoveMaximumNumbers(int[] array, int max, int count)
        {
            //array = array.Where(x => x != array.Max()).ToArray();
            int[] newArray = new int[array.Length - count];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != max)
                {
                    newArray[index] = array[i];
                    index++;
                }
            }

            return newArray;
        }
    }
}
