using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayHelpers;

namespace Array2_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayHelpers.ArrayHelpers.GenerateArray(25, -100, 100);
            PrintArray(array);
            Console.WriteLine();
            int maxNumber = ArrayHelpers.ArrayHelpers.FindMax(array);
            int numberOfMaximumNumbers = ArrayHelpers.ArrayHelpers.FindNumberOfMaximumNumbers(array, maxNumber);
            int newNumber = EnterNumber();
            int[] newArray = InsertNewNumberAfterAllMaximum(array, maxNumber, numberOfMaximumNumbers, newNumber);
            PrintArray(newArray);
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        private static int EnterNumber()
        {
            Console.WriteLine("\nВведите число: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int[] InsertNewNumberAfterAllMaximum(int[] array, int max, int count, int number)
        {
            int[] newArray = new int[array.Length + count];
            int newIndex = 0;

            for(int i = 0 ; i < array.Length ; i++)
            {
                newArray[newIndex] = array[i];
                newIndex++;

                if (array[i] == max)
                {
                    newArray[newIndex] = number;
                    newIndex++;
                }
            }

            return newArray;
        }
    }
}
