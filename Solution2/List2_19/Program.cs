using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonList;
using Microsoft.Win32;

namespace List2_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = ListHelpers.GenerateArray(10, 0, 5);
            PrintList(list);
            Console.WriteLine();
            int number = WriteNumber();
            int maxNumber = ListHelpers.FindMax(list);
            int countMaxNumber = ListHelpers.FindCountMaxNumber(list, maxNumber);
            var newList = ListHelpers.InsertNewElementAfterAllMaximum(list, maxNumber, number, countMaxNumber);
            PrintList(newList);
        }

        static void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
        }

        public static int WriteNumber()
        {
            Console.WriteLine("\nВведите число: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
    }
}
