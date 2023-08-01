using System;

namespace ArrayHelpers
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

    }
}
