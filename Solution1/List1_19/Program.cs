using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListHelpers;

namespace List1_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = ListHelpers.ListHelpers.GenerateArray(25, -300, 300);
            PrintList(list);
            Console.WriteLine();
            list.Reverse();
            PrintList(list);
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
