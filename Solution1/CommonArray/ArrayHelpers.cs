using System;

namespace CommonArray
{
    public class ArrayHelpers
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

        public static void ReplacePositiveNumbers(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = number;
                }
            }
        }

        public static int[] ReplaceEvenElements(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array[i] = number;
                }
            }

            return array;
        }

        public static void RearrangElements(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int value = array[i * 2 + 1];
                array[i * 2 + 1] = array[i * 2];
                array[i * 2] = value;
            }
        }

        public static void ReplaceTwoDigit(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int abs = Math.Abs(array[i]);
                if (abs >= 10 && abs <= 99)
                {
                    array[i] = number;
                }
            }
        }
    }
}
