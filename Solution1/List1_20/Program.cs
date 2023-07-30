using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List1_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> array = GenerateArray(25, -100, 100);
            PrintArray(array);
            Console.WriteLine();
            ReplaceElements(array);
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

        static void ReplaceElements(List<int> array)
        {
            List<int> newArray = new List<int>(array);

            for (int i = 0; i < array.Count / 2; i++)
            {
                int value = array[i * 2 + 1];
                newArray[i * 2 + 1] = array[i * 2];
                newArray[i * 2] = value;
            }

            foreach (int item in newArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}