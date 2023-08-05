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

        public static int FindNumberOfOddNumbers(List<int> list)
        {
            int countMax = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    countMax++;
                }
            }

            return countMax;
        }


        public static List<int> DeleteEvenNumbers(List<int> list, int countMax)
        {
            //list.RemoveAll(i => i % 2 == 0);

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] % 2 == 0)
                {
                    list.RemoveAt(i);
                }
            }

            return list;
        }

       public static List<int> InsertNewElementAfterAllMaximum(List<int> list, int max, int number, int count)
        {
            List<int> newList = new List<int>(list.Count + count);

            for (int i = 0; i < list.Count; i++)
            {
                newList.Add(list[i]);

                if (list[i] == max)
                {
                    newList.Add(number);
                }
            }

            return newList;
        }

        public static List<int> RemoveMaxElements(List<int> list, int max)
        {
            //int maxElements = list.Max();
            //list.RemoveAll(x => x == maxElements);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == max)
                {
                    list.RemoveAt(i);
                }
            }

            return list;
        }

        public static List<int> InsertNewElementInFrontAllElementsThatHaveDigitInTheirRecords(List<int> list, int number, int digit)
        {
            List<int> newArr = new List<int>();

            foreach (int item in list)
            {
                int ind = item.ToString().IndexOf(digit.ToString());

                if (ind != -1)
                {
                    newArr.Add(number);
                }

                newArr.Add(item);
            }

            return newArr;
        }

        public static List<int> RemoveElements(List<int> list, int k1, int k2)
        {
            list.RemoveRange(k1, k2 + 1);
            return list;
        }
    }
}
