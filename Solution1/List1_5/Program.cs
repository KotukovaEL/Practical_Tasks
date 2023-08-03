using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListHelpers;

namespace List1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = ListHelpers.ListHelpers.GenerateArray(25, -300, 300);
            PrintList(list);
            Console.WriteLine();
            int number = WriteNumber();
            ReplaceElements(list, number);
            PrintList(list);
        }

        static void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
        }

        private static int WriteNumber()
        {
            Console.WriteLine("Введите любое число: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static void ReplaceElements(List<int> list, int number)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int abs = Math.Abs(list[i]);
                if (abs >= 10 && abs <= 99)
                {
                    list[i] = number;
                }
            }
        }
    }
}
