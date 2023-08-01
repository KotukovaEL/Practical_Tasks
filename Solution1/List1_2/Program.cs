﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListHelpers;

namespace List1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = ListHelpers.ListHelpers.GenerateArray(25, -100, 100);
            PrintList(list);
            Console.WriteLine();
            ReplaceElements(list);
            PrintList(list);
        }

        static void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
        }

        static void ReplaceElements(List<int> list)
        {
            Console.WriteLine("Введите любое число: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    list[i] = number;
                }
            }
        }
    }
}
