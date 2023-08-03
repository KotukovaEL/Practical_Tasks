using System;
using System.Linq;

namespace ArrayHelpers
{
    public static class ArrayHelpers
    {
        public static int[] GenerateArray(int length, int minValue, int maxValue)
        {
            int[] array = new int[length];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }

            return array;
        }

        public static int FindMax(int[] array)
        {
            int max = array[0];

            for (int i = 1; i < array.Length; ++i)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        public static int FindNumberOfMaximumNumbers(int[] array, int max)
        {
            int count = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] == max)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
