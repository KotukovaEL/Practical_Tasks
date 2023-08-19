using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonList;

namespace List2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = ListHelpers.GenerateArray(20, -10, 10);
            PrintList(list);
            Console.WriteLine();
            int k1 = WriteK1();
            int k2 = WriteK2();
            var newList = ListHelpers.RemoveElements(list, k1, k2);
            PrintList(newList);
        }

        static void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
        }

        private static int WriteK1()
        {
            Console.WriteLine("Введите k1: ");
            int k1 = int.Parse(Console.ReadLine());
            return k1;
        }

        private static int WriteK2()
        {
            Console.WriteLine("Введите k2: ");
            int k2 = int.Parse(Console.ReadLine());
            return k2;
        }
    }
}