using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = GenerateArray(25, -100, 100);
            PrintArray(array);
            Console.WriteLine();
            InsertNumber(array);
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

        static int[] InsertNumber(int[] array)
        {
            Console.WriteLine("\nВведите число: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите цифру: ");
            int digit = int.Parse(Console.ReadLine());
            int count = 0;

           for(int i = 0; i < array.Length; i++) 
            {
               if(array[i].ToString().Contains(digit.ToString()))
                {
                    count++;
                }
            }

            int[] array2 = new int[array.Length + count];
            int newInd = 0;

            for(int i = 0 ; i < array.Length ; i++)
            {
                if (array[i].ToString().Contains(digit.ToString()))
                {
                    array2[newInd] = number;
                    newInd++;
                }

                array2[newInd] = array[i];
                newInd++;
            }

            array = array2;

            foreach (int i in array2)
            {
                Console.Write(i + " ");
            }

            return array2;
        }
    }
}