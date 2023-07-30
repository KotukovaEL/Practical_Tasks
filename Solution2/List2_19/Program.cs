using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List2_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> array = GenerateArray(10, 0, 5);
            PrintArray(array);
            Console.WriteLine();
            int maxNumber = FindMax(array);
            InsertNumber(array, maxNumber);
        }

        static void PrintArray(List<int> array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
        }

        static List<int> GenerateArray(int length, int minValue, int MaxValue)
        {
            Random random = new Random();
            List<int> array = new List<int>(length);
            for (int i = 0; i < length; i++)
            {
                array.Add(random.Next(minValue, MaxValue));
            }

            return array;
        }

        static int FindMax(List<int> array)
        {
            int max = array[0];

            for (int i = 1; i < array.Count; ++i)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }
        static void InsertNumber(List<int> array, int max)
        {
            Console.WriteLine("\nВведите число: ");
            int number = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < array.Count; ++i)
            {
                if (array[i] == max)
                {
                    count++;
                }
            }

            int[] newArr = new int[array.Count + count];
            int newInd = 0;

            for (int i = 0; i < array.Count; i++)
            {
                newArr[newInd] = array[i];
                newInd++;

                if (array[i] == max)
                {
                    newArr[newInd] = number;
                    newInd++;
                }
            }

            foreach (int i in newArr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
