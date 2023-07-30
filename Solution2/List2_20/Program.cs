using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List2_20
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
        static List<int> InsertNumber(List<int> array, int max)
        {
            Console.WriteLine("\nВведите число: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите цифру: ");
            int digit = int.Parse(Console.ReadLine());
            List<int> newArr = new List<int>();
            
            foreach (int item in array)
            {
                int ind = item.ToString().IndexOf(digit.ToString());
                
                if(ind != -1)
                {
                    newArr.Add(number);
                }

                newArr.Add(item);
            }


            foreach (int i in newArr)
            {
                Console.Write(i + " ");
            }

            return newArr;
        }
    }
}
