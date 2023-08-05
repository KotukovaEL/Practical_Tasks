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

        public static int[] SelectOddNumbers(int[] array, int count)
        {
            //array = array.Where(x => x % 2 != 0).ToArray();
            int[] newArray = new int[count];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    newArray[index] = array[i];
                    index++;
                }
            }

            return newArray;
        }

        public static int FindNumberOfOddNumbers(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static int[] InsertNewNumberAfterAllMaximum(int[] array, int max, int count, int number)
        {
            int[] newArray = new int[array.Length + count];
            int newIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                newArray[newIndex] = array[i];
                newIndex++;

                if (array[i] == max)
                {
                    newArray[newIndex] = number;
                    newIndex++;
                }
            }

            return newArray;
        }

        public static int[] RemoveMaximumNumbers(int[] array, int max, int countMax)
        {
            //array = array.Where(x => x != array.Max()).ToArray();
            int[] newArray = new int[array.Length - countMax];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != max)
                {
                    newArray[index] = array[i];
                    index++;
                }
            }

            return newArray;
        }
        
        public  static int CountDigit(int[] array, int digit)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                var value = digit.ToString();
                bool value1 = array[i].ToString().Contains(value);
                if (value1)
                {
                    count++;
                }
            }

            return count;
        }
        public static int[] InsertBeforeElementsWithDigit(int[] array, int number, int digit, int count)
        {
            int[] array2 = new int[array.Length + count];
            int newInd = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].ToString().Contains(digit.ToString()))
                {
                    array2[newInd] = number;
                    newInd++;
                }

                array2[newInd] = array[i];
                newInd++;
            }

            return array2;
        }

        public static void RemoveElementsFromK1ToK2(ref int[] array, int k1, int k2)
        {
            int[] newArray = new int[array.Length - k1 - k2 - 1];
            int newIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i < k1 || i > k2)
                {
                    newArray[newIndex] = array[i];
                    newIndex++;
                }
            }
            array = newArray;
        }
    }
}
