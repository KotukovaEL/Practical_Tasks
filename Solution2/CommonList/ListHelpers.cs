using System;
using System.Collections.Generic;

namespace CommonList
{
    public class ListHelpers
    {
        public static List<int> GenerateArray(int length, int minValue, int MaxValue)
        {
            Random random = new Random();
            List<int> list = new List<int>(length);
            for (int i = 0; i < length; i++)
            {
                list.Add(random.Next(minValue, MaxValue));
            }

            return list;
        }


        public static int FindMax(List<int> list)
        {
            int max = list[0];

            for (int i = 1; i < list.Count; ++i)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }

            return max;
        }

        public static int FindCountMaxNumber(List<int> list, int max)
        {
            int count = 0;

            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i] == max)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
