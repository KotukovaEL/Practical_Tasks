using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = GenerateArray(25, -100, 100);
            PrintArray(array);
            Console.WriteLine();
            int maxNumber = FindMax(array);
            InsertNumber(array, maxNumber);
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

        static int FindMax(int[] array)
        {
            int max = array[0];

            for(int i = 1; i < array.Length; ++i)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        static void InsertNumber(int[] array, int max)
        {
            Console.WriteLine("\nВведите число: ");
            int number = int.Parse(Console.ReadLine());
            int count = 0;

            for(int i = 0 ; i < array.Length ; ++i)
            {
                if (array[i] == max)
                {
                    count++;
                }
            }

            int[] newArr = new int[array.Length + count];
            int newInd = 0;

            for(int i = 0 ; i < array.Length ; i++)
            {
                newArr[newInd] = array[i];
                newInd++;

                if (array[i] == max)
                {
                    newArr[newInd] = number;
                    newInd++;
                }
            }

            foreach(int i in newArr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
