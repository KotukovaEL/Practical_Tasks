using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonList;

namespace List2_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = ListHelpers.GenerateArray(10, 0, 5);
            PrintList(list);
            int number = WriteNumber();
            int digit = WriteDigit();
            Console.WriteLine();
            var newList = ListHelpers.InsertNewElementInFrontAllElementsThatHaveDigitInTheirRecords(list, number, digit);
            PrintList(newList);
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
            Console.WriteLine("\nВведите число: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        private static int WriteDigit()
        {
            Console.WriteLine("\nВведите число: ");
            int digit = int.Parse(Console.ReadLine());
            return digit;
        }
    }
}
