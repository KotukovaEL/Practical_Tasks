using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List1_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> array = GenerateArray(25, -300, 300);
            PrintArray(array);
            Console.WriteLine();
            RearrangElements(array);
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

        static void RearrangElements(List<int> array)
        {
            List<int> newArray = new List<int>(array.Count);
            newArray.AddRange(array);
            newArray.Reverse();
            foreach (int i in newArray)
            {
                Console.Write(i + " ");
            }
        }
    }
}
