using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CommonArray;

namespace Array2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayHelpers.GenerateArray(25, -300, 300);
            PrintArray(array);
            Console.WriteLine();
            int oddNumbers = ArrayHelpers.FindNumberOfOddNumbers(array);
            int[] newArray = ArrayHelpers.SelectOddNumbers(array, oddNumbers);
            PrintArray(newArray);
        }

        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }        
    }
}
