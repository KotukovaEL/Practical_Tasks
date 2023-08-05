using System;
using System.Collections.Generic;

namespace CommonList
{
    public class ListHelpers
    {
        public static List<int> GenerateArray(int length, int minValue, int maxValue)
        {
            Random random = new Random();
            List<int> list = new List<int>(length);
            for (int i = 0; i < length; i++)
            {
                list.Add(random.Next(minValue, maxValue));
            }

            return list;
        }

        public static void ReplacePositiveNumbers(List<int> list, int number)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 0)
                {
                    list[i] = number;
                }
            }
        }

        public static void ReplaceEvenElements(List<int> list, int number)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    list[i] = number;
                }
            }
        }

        public static void RearrangElements(List<int> list)
        {
            for (int i = 0; i < list.Count / 2; i++)
            {
                int value = list[i * 2 + 1];
                list[i * 2 + 1] = list[i * 2];
                list[i * 2] = value;
            }
        }

        public static void ReplaceTwoDigit(List<int> list, int number)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int abs = Math.Abs(list[i]);
                if (abs >= 10 && abs <= 99)
                {
                    list[i] = number;
                }
            }
        }
    }
}
