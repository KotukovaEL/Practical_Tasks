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
            List<int> list = ListHelpers.GenerateArray(25, -300, 300);
            PrintList(list);
            Console.WriteLine();
            int oddNumbers = FindNumberOfOddNumbers(list);
            var newList = DeleteEvenNumbers(list, oddNumbers);
            PrintList(newList);
        }

        static void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
        }

        private static int FindNumberOfOddNumbers(List<int> list)
        {
            int count = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }


        static List<int> DeleteEvenNumbers(List<int> list, int count)
        {
            //list.RemoveAll(i => i % 2 == 0);

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] % 2 == 0)
                {
                    list.RemoveAt(i);
                }
            }

            return list;
        }
    }
}