using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonArray;

namespace Array2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayHelpers.GenerateArray(25, -10, 10);
            PrintArray(array);
            Console.WriteLine();
            int maxNumber = ArrayHelpers.FindMax(array);
            int numberOfMaximumNumbers = ArrayHelpers.FindNumberOfMaximumNumbers(array, maxNumber);
            int[] newArray = ArrayHelpers.RemoveMaximumNumbers(array, maxNumber, numberOfMaximumNumbers);
            PrintArray(newArray);
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
