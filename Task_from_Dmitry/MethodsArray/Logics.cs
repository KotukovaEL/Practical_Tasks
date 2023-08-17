using System;

namespace MethodsArray
{
    public class Logics
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

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static int[] MergeArray(int[] array1, int[] array2)
        {
            var array3 = new int[array1.Length + array2.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i];
            }

            for (int j = array1.Length; j < array3.Length; j++)
            {
                array3[j] = array2[j - array1.Length];
            }
            SortArray(array3);
            return array3;
        }

        public static int[] SortArray(int[] array)
        {
            var index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        index = array[i];
                        array[i] = array[j];
                        array[j] = index;
                    }
                }
            }
            return array;
        }
    }
}
