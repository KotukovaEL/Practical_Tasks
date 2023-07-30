using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> array = GenerateArray(25, -300, 300);
            PrintArray(array);
            Console.WriteLine();
            RemoveElements(array);
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

        static void RemoveElements(List<int> array)
        {
            array.RemoveAll(i => i % 2 == 0);

            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}