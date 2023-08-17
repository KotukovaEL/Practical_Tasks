using System;
using System.Collections.Generic;

namespace MethodsList
{
    public class Logics
    {
        public static List<int> GenerateList(int length, int minValue, int maxValue)
        {
            Random random = new Random();
            List<int> list = new List<int>(length);
            for (int i = 0; i < length; i++)
            {
                list.Add(random.Next(minValue, maxValue));
            }

            return list;
        }

        public static void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
        }

        public static List<int> MergeList(List<int> list1, List<int> list2)
        {
            var list3 = new List<int> (list1.Count + list2.Count);
            for (int i = 0; i < list1.Count; i++)
            {
                list3.Add(list1[i]);
            }

            for (int j = list1.Count; j < list3.Capacity; j++)
            {
                list3.Add(list2[j - list1.Count]);
            }
            SortList(list3);
            return list3;
        }

        public static List<int> SortList(List<int> list)
        {
            var index = 0;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        index = list[i];
                        list[i] = list[j];
                        list[j] = index;
                    }
                }
            }
            return list;
        }
    }
}
