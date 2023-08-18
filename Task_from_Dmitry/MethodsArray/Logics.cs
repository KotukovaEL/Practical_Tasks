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
            int ind1 = 0;
            int ind2 = 0;
            for (int i = 0; i < array3.Length; i++)
            {
                if(ind1 < array1.Length && ind2 < array2.Length)
                {
                    if (array1[ind1] < array2[ind2])
                    {
                        array3[i] = array1[ind1];
                        array3[i + 1] = array2[ind2];
                        ind1++;
                    }
                    else
                    {
                        array3[i] = array2[ind2];
                        array3[i + 1] = array1[ind1];
                        ind2++;
                    }
                }
                else if (ind1 < array1.Length)
                {
                    array3[i] = array1[ind1];
                    ind1++;
                }
                else
                {
                    //Array.Copy(array2, ind2, array3, array2.Length - ind2, array2.Length);
                    array3[i] = array2[ind2];
                    ind2++;
                }
            }

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
