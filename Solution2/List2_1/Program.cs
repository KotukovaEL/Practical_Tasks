using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonList;

namespace List2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>() { 2, 2, 2, 2, 2, 2};
            List<int> list = ListHelpers.GenerateArray(25, -300, 300);
            PrintList(list);
            Console.WriteLine();
            int oddNumbers = ListHelpers.FindNumberOfOddNumbers(list);
            var newList = ListHelpers.DeleteEvenNumbers(list, oddNumbers);
            PrintList(newList);
        }

        static void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}