﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = GenerateArray(25, -300, 300);
            PrintArray(array);
            Console.WriteLine();
            ReplaceElements(array);
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static int[] GenerateArray(int length, int minValue, int MaxValue)
        {
            int[] array = new int[length];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, MaxValue);
            }
            return array;
        }

        static void ReplaceElements(int[] array)
        {
            Console.WriteLine("Введите любое число: ");
            int number = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < array.Length; i++)
            {
                int abs = Math.Abs(array[i]);
                if (abs >= 10 && abs <= 99)
                {
                    array[i] = number;
                }

                Console.Write(array[i] + " ");
            }
        }
    }
}