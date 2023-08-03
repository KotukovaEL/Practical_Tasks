using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ArrayHelpers;

namespace Array2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayHelpers.ArrayHelpers.GenerateArray(25, -300, 300);
            PrintArray(array);
            Console.WriteLine();
            int oddNumbers = FindNumberOfOddNumbers(array);
            int[] newArray = SelectOddNumbers(array, oddNumbers);
            PrintArray(newArray);
        }

        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        private static int FindNumberOfOddNumbers (int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        private static int[] SelectOddNumbers(int[] array, int count)
        {
            //array = array.Where(x => x % 2 != 0).ToArray();
            int[] newArray = new int[count];
            int index = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    newArray[index] = array[i];
                    index++;
                }
            }
            
            return newArray;
        }
    }
}
