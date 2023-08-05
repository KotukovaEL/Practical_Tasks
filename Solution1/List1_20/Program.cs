using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonList;

namespace List1_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = ListHelpers.GenerateArray(25, -100, 100);
            PrintList(list);
            Console.WriteLine();
            ListHelpers.RearrangElements(list);
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