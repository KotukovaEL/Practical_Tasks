using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List1_2
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
            Console.WriteLine("Введите любое число: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array[i] = number;
                }

                Console.Write(array[i] + " ");
            }
        }
    }
}
