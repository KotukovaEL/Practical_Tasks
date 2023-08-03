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
            int maxNumber = ListHelpers.FindMax(list);
            var newList = InsertNewElementInFrontAllElementsThatHaveDigitInTheirRecords(list, maxNumber, number, digit);
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

        static List<int> InsertNewElementInFrontAllElementsThatHaveDigitInTheirRecords(List<int> list, int max, int number, int digit)
        {       
            List<int> newArr = new List<int>();
            
            foreach (int item in list)
            {
                int ind = item.ToString().IndexOf(digit.ToString());
                
                if(ind != -1)
                {
                    newArr.Add(number);
                }

                newArr.Add(item);
            }

            return newArr;
        }
    }
}
