using System;
using System.Collections.Generic;

namespace ListHelpers
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
    }
}
