using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonList;

namespace List2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = ListHelpers.GenerateArray(20, -10, 10);
            PrintList(list);
            Console.WriteLine();
            int maxNumber = ListHelpers.FindMax(list);
            var newList = ListHelpers.RemoveMaxElements(list, maxNumber);
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