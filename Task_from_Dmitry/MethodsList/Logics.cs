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
            var list3 = new List<int>(list1.Count + list2.Count);
            int ind1 = 0;
            int ind2 = 0;
            for (int i = 0; i < list3.Capacity; i++)
            {
                if (ind1 < list1.Count && ind2 < list2.Count)
                {
                    if (list1[ind1] < list2[ind2])
                    {
                        list3.Add(list1[ind1]);
                        ind1++;
                    }
                    else
                    {
                        list3.Add(list2[ind2]);
                        ind2++;
                    }
                }
                else if (ind1 < list1.Count)
                {
                    list3.Add(list1[ind1]);
                    ind1++;
                }
                else
                {
                    list3.Add(list2[ind2]);
                    ind2++;
                }
            }

            return list3;
        }

        public static List<int> MergeListWithWhile(List<int> list1, List<int> list2)
        {
            var list3 = new List<int>(list1.Count + list2.Count);
            int ind1 = 0;
            int ind2 = 0;

            while (ind1 < list1.Count && ind2 < list2.Count)
            {
                if (list1[ind1] < list2[ind2])
                {
                    list3.Add(list1[ind1]);
                    //list3[i + 1] = list2[ind2];
                    ind1++;
                }
                else
                {
                    list3.Add(list2[ind2]);
                    //list3[i + 1] = list1[ind1];
                    ind2++;
                }
            }

            while (ind1 < list1.Count)
            {
                list3.Add(list1[ind1]);
                ind1++;
            }

            while (ind2 < list2.Count)
            {
                list3.Add(list2[ind2]);
                ind2++;
            }

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
